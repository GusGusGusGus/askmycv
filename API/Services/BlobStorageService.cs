using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Intefaces;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Options;

namespace API.Services
{
   public class BlobStorageService : IBlobStorageService
    {
        private readonly BlobStorageOptions _azureBlobSettings;
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _containerName;

        public BlobStorageService(IOptions<BlobStorageOptions> azureBlobOptions)
        {
            _azureBlobSettings = azureBlobOptions.Value;
            _blobServiceClient = new BlobServiceClient(_azureBlobSettings.ConnectionString);
            _containerName = _azureBlobSettings.ContainerName;
        }

        // Upload different types of files (PDF, JPEG, DOCX, etc.)
        public async Task<string> UploadFileAsync(Stream fileStream, string fileName, string userId, string contentType)
        {
            try
            {
                var blobContainerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                string userSpecificFileName = $"{userId}/{fileName}"; // Storing by user folder

                var blobClient = blobContainerClient.GetBlobClient(userSpecificFileName);
                await blobClient.UploadAsync(fileStream, new BlobHttpHeaders { ContentType = contentType });

                return blobClient.Uri.ToString(); // Return the URL of the uploaded file
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework here)
                Console.WriteLine($"An error occurred while uploading the file: {ex.Message}");
                return null; // Return null if there was an error
            }
        }

        // Download user-specific file
        public async Task<Stream> DownloadFileAsync(string fileName, string userId)
        {
            try
            {
                var blobContainerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                string userSpecificFileName = $"{userId}/{fileName}";

                var blobClient = blobContainerClient.GetBlobClient(userSpecificFileName);
                var blobDownloadInfo = await blobClient.DownloadAsync();
                return blobDownloadInfo.Value.Content;
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework here)
                Console.WriteLine($"An error occurred while downloading the file: {ex.Message}");
                return null; // Return null if there was an error
            }
        }

        // Delete user-specific file
        public async Task<bool> DeleteFileAsync(string fileName, string userId)
        {
            try
            {
                var blobContainerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                string userSpecificFileName = $"{userId}/{fileName}";

                var blobClient = blobContainerClient.GetBlobClient(userSpecificFileName);

                var result = await blobClient.DeleteIfExistsAsync();

                return result.Value; // Return true if the file was deleted, false if it did not exist
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework here)
                Console.WriteLine($"An error occurred while deleting the file: {ex.Message}");
                return false; // Return false if there was an error
            }
        }

        //update user-specific file
        public async Task<string> UpdateFileAsync(Stream fileStream, string fileName, string userId, string contentType)
        {
            try
            {
                var blobContainerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                string userSpecificFileName = $"{userId}/{fileName}";

                var blobClient = blobContainerClient.GetBlobClient(userSpecificFileName);
                var blobUploadOptions = new BlobUploadOptions
                {
                    HttpHeaders = new BlobHttpHeaders { ContentType = contentType }
                };
                await blobClient.UploadAsync(fileStream, blobUploadOptions);

                return blobClient.Uri.ToString(); // Return the URL of the uploaded file
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework here)
                Console.WriteLine($"An error occurred while updating the file: {ex.Message}");
                return null; // Return null if there was an error
            }
        }

        //list all files
        public async Task<List<string>> ListFilesAsync(string userId)
        {
            try
            {
                var blobContainerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
                var files = new List<string>();

                await foreach (var blobItem in blobContainerClient.GetBlobsAsync())
                {
                    if (blobItem.Name.StartsWith(userId + "/"))
                    {
                        files.Add(blobItem.Name);
                    }
                }
                return files;
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework here)
                Console.WriteLine($"An error occurred while listing the files: {ex.Message}");
                return null; // Return null if there was an error
            }
        }

        
                        
    }
}