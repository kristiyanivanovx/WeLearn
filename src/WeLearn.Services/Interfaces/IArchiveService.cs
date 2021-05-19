using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace WeLearn.Services.Interfaces
{
    public interface IArchiveService
    {
        public Stream ArchiveFiles(IEnumerable<IFormFile> files);

        public Task<Stream> ArchiveFilesAsync(IEnumerable<IFormFile> files);
    }
}
