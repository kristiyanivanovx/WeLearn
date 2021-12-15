using System.IO;
using System.Net;

using WeLearn.Data.Models.InputOutput;
using WeLearn.Services.Interfaces;

namespace WeLearn.Services
{
    public class FileDownloadService : IFileDownloadService
    {
        public FileDownload DownloadFile(string link)
        {
            string contentType = "application/octet-stream";
            string fileName = "download.zip";

            WebClient webClient = new WebClient();
            byte[] data = webClient.DownloadData(link);
            MemoryStream content = new MemoryStream(data);

            return new FileDownload { Content = content, ContentType = contentType, FileName = fileName };
        }
    }
}
