using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.IO.Compression;
using WeLearn.Services.Interfaces;
using System;

namespace WeLearn.Services
{
    public class InputOutputService : IInputOutputService
    {
        public Stream ArchiveFiles(IEnumerable<IFormFile> files)
        {
            MemoryStream stream = new MemoryStream();
            using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen: true))
            {
                foreach (IFormFile file in files)
                {
                    ZipArchiveEntry entry = archive.CreateEntry(file.FileName, CompressionLevel.Fastest);
                    using (Stream target = entry.Open())
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
            MemoryStream stream = new MemoryStream();
            using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen: true))
            {
                foreach (IFormFile file in files)
                {
                    ZipArchiveEntry entry = archive.CreateEntry(file.FileName, CompressionLevel.Fastest);
                    using (Stream target = entry.Open())
                    {
                        await file.OpenReadStream().CopyToAsync(target);
                    }
                }
            }

            stream.Position = 0;
            return stream;
        }

        public ZipArchive CreateZipArchiveWithTempFiles(string tempDirectory, string actualDirectoryPlusZipName)
        {
            ZipArchive archive = ZipFile.Open(actualDirectoryPlusZipName, ZipArchiveMode.Create);
            foreach (string file in Directory.GetFiles(tempDirectory))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }

            return archive;
        }

        public void DeleteFilesInFolder(string tempDirectory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(tempDirectory);
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        public string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            string uniqueFileName = Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 5)
                      + Path.GetExtension(fileName);

            return uniqueFileName;
        }

        public string GenerateItemPath(string root, string subItem, string subSubItem = null) 
            => Path.Combine(root, subItem, subSubItem);
    }
}
