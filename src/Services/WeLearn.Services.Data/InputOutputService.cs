﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using WeLearn.Services.Data.Interfaces;

namespace WeLearn.Services.Data
{
    public class InputOutputService : IInputOutputService
    {
        public async Task<Stream> ArchiveFilesAsync(IEnumerable<IFormFile> files)
        {
            MemoryStream stream = new MemoryStream();
            using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen: true))
            {
                foreach (IFormFile file in files)
                {
                    ZipArchiveEntry entry = archive.CreateEntry(file.FileName, CompressionLevel.Fastest);
                    await using (Stream target = entry.Open())
                    {
                        await file.OpenReadStream().CopyToAsync(target);
                    }
                }
            }

            stream.Position = 0;
            return stream;
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
            => subSubItem == null ?
                Path.Combine(root, subItem) :
                Path.Combine(root, subItem, subSubItem);
    }
}
