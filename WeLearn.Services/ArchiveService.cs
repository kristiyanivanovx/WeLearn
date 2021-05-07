using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.IO.Compression;
using WeLearn.Services.Interfaces;

namespace WeLearn.Services
{
    // https://stackoverflow.com/a/59860450/13146140
    public class ArchiveService : IArchiveService
    {
        public Stream ArchiveFiles(IEnumerable<IFormFile> files)
        {
            MemoryStream stream = new MemoryStream();
            using ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen: true);

            foreach (IFormFile file in files)
            {
                var entry = archive.CreateEntry(file.FileName, CompressionLevel.Fastest);
                using Stream target = entry.Open();
                file.CopyTo(target);
            }

            stream.Position = 0;
            return stream;
        }

        public async Task<Stream> ArchiveFilesAsync(IEnumerable<IFormFile> files)
        {
            MemoryStream stream = new MemoryStream();
            using ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen: true);

            foreach (IFormFile file in files)
            {
                var entry = archive.CreateEntry(file.FileName, CompressionLevel.Fastest);
                using Stream target = entry.Open();
                await file.OpenReadStream().CopyToAsync(target);
            }

            stream.Position = 0;
            return stream;
        }
    }
}
