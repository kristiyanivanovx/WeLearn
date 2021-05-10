using System.IO;
using System.Net;
using WeLearn.Services.Interfaces;
using WeLearn.Services.HelperModels;

namespace WeLearn.Services
{
    public class FileDownloadService : IFileDownloadService
    {
        public FileDownload DownloadFile(string link)
        {
            WebClient webClient = new WebClient();
            byte[] data = webClient.DownloadData(link);
            MemoryStream content = new MemoryStream(data);
            string contentType = "application/octet-stream";
            string fileName = "download.zip";

            return new FileDownload { Content = content, ContentType = contentType, FileName = fileName };
        }
    }
}
