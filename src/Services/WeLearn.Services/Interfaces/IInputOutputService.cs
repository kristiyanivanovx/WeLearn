using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace WeLearn.Services.Interfaces
{
    public interface IInputOutputService
    {
        Stream ArchiveFiles(IEnumerable<IFormFile> files);

        Task<Stream> ArchiveFilesAsync(IEnumerable<IFormFile> files);

        string GetUniqueFileName(string fileName);

        string GenerateItemPath(string root, string subItem, string subSubItem = null);
    }
}
