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
            var webClient = new WebClient();
            var data = webClient.DownloadData(link);
            var content = new MemoryStream(data);
            var contentType = "application/octet-stream";
            var fileName = "download.zip";

            return new FileDownload { Content = content, ContentType = contentType, FileName = fileName };
        }
    }
}
