using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Intefaces
{
    public interface IBlobStorageService
    {
        Task<string> UploadFileAsync(Stream fileStream, string fileName, string userId, string contentType, bool isCV);
        Task<Stream> DownloadFileAsync(string fileName, string userId);
        Task<string> UpdateFileAsync(Stream fileStream, string fileName, string userId, string contentType);
        Task<bool> DeleteFileAsync(string fileName, string userId);
        Task<List<string>> ListFilesAsync(string userId);
    }
}