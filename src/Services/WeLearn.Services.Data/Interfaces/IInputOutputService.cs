﻿using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IInputOutputService
    {
        Task<Stream> ArchiveFilesAsync(IEnumerable<IFormFile> files);

        string GetUniqueFileName(string fileName);

        string GenerateItemPath(string root, string subItem, string subSubItem = null);
    }
}
