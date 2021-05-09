using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.IO.Compression;
using WeLearn.Services.Interfaces;

namespace WeLearn.Services
{
    public class ArchiveService : IArchiveService
    {
        public Stream ArchiveFiles(IEnumerable<IFormFile> files)
        {
            var stream = new MemoryStream();
            using (var archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen: true))
            {
                foreach (var file in files)
                {
                    var entry = archive.CreateEntry(file.FileName, CompressionLevel.Fastest);
                    using (var target = entry.Open())
                    {
                        file.CopyTo(target);
                    }
                }
            }

            stream.Position = 0;
            return stream;
        }

        public async Task<Stream> ArchiveFilesAsync(IEnumerable<IFormFile> files)
        {
            var stream = new MemoryStream();
            using (var archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen: true))
            {
                foreach (var file in files)
                {
                    var entry = archive.CreateEntry(file.FileName, CompressionLevel.Fastest);
                    using (var target = entry.Open())
                    {
                        await file.OpenReadStream().CopyToAsync(target);
                    }
                }
            }

            stream.Position = 0;
            return stream;
        }
    }
}
