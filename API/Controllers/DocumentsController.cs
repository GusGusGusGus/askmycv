using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Intefaces;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class DocumentsController : BaseApiController
    {
        private readonly IBlobStorageService _blobStorageService;

        public DocumentsController(IBlobStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;
        }

        // Endpoint to upload CV files (PDF, JPEG, DOCX, WebP, etc.)
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            // Set a reasonable file size limit (e.g., 20 MB)
            const long maxFileSize = 20 * 1024 * 1024; // 20 MB

            if (file.Length > maxFileSize)
            {
                return BadRequest("File size exceeds the 10 MB limit.");
            }

            // Get the logged-in user's ID (assumed to be set in the authentication token/claims)
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User is not authenticated.");
            }

            // Supported content types
            var allowedContentTypes = new[] { 
                "application/pdf", 
                "image/jpeg", 
                "image/png", 
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document", 
                "image/webp" 
            };

            if (!allowedContentTypes.Contains(file.ContentType))
            {
                return BadRequest("Unsupported file type.");
            }

            using (var stream = file.OpenReadStream())
            {
                // Save file under the user's folder in Azure Blob Storage
                var fileUrl = await _blobStorageService.UploadFileAsync(stream, file.FileName, userId, file.ContentType);
                return Ok(new { Url = fileUrl });
            }
        }

        // Endpoint to download a file by name
        [HttpGet("download/{fileName}")]
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User is not authenticated.");
            }

            // Fetch the file for the authenticated user
            var fileStream = await _blobStorageService.DownloadFileAsync(fileName, userId);

            if (fileStream == null)
            {
                return NotFound("File not found.");
            }

            // Get content type based on the file extension (you can add more cases as needed)
            var contentType = fileName.EndsWith(".pdf") ? "application/pdf" :
                            fileName.EndsWith(".jpeg") ? "image/jpeg" :
                            fileName.EndsWith(".png") ? "image/png" :
                            fileName.EndsWith(".docx") ? "application/vnd.openxmlformats-officedocument.wordprocessingml.document" :
                            fileName.EndsWith(".webp") ? "image/webp" : "application/octet-stream";

            return File(fileStream, contentType, fileName);
        }

        // Endpoint to delete a file by name
        [HttpDelete("delete/{fileName}")]
        public async Task<IActionResult> DeleteFile(string fileName)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User is not authenticated.");
            }

            var result = await _blobStorageService.DeleteFileAsync(fileName, userId);

            if (!result)
            {
                return NotFound("File not found.");
            }

            return Ok("File deleted successfully.");
        }

        // Endpoint to update a file by name
        [HttpPut("update/{fileName}")]
        public async Task<IActionResult> UpdateFile(string fileName, IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User is not authenticated.");
            }

            // Supported content types
            var allowedContentTypes = new[] { 
                "application/pdf", 
                "image/jpeg", 
                "image/png", 
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document", 
                "image/webp" 
            };

            if (!allowedContentTypes.Contains(file.ContentType))
            {
                return BadRequest("Unsupported file type.");
            }

            using (var stream = file.OpenReadStream())
            {
                // Update file under the user's folder in Azure Blob Storage
                var fileUrl = await _blobStorageService.UpdateFileAsync(stream, fileName, userId, file.ContentType);
                return Ok(new { Url = fileUrl });
            }
        }

        // Endpoint to list all files for a user
        [HttpGet("list")]
        public async Task<IActionResult> ListAllFilesForUser()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User is not authenticated.");
            }

            var files = await _blobStorageService.ListFilesAsync(userId);

            return Ok(files);
        }
    }
}