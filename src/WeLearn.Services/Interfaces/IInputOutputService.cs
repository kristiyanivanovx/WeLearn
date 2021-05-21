using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO.Compression;
using Microsoft.AspNetCore.Http;

namespace WeLearn.Services.Interfaces
{
    public interface IInputOutputService
    {
        public Stream ArchiveFiles(IEnumerable<IFormFile> files);

        public Task<Stream> ArchiveFilesAsync(IEnumerable<IFormFile> files);

        public string GetUniqueFileName(string fileName);

        public string GenerateItemPath(string root, string subItem, string subSubItem = null);
    }
}
