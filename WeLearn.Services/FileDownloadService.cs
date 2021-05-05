using System.IO;
using System.Net;
using WeLearn.Services.Interfaces;
using WeLearn.Infrastructure.HelperModels;

namespace WeLearn.Services
{
    public class FileDownloadService : IFileDownloadService
    {
        public FileParsed DownloadFile(string link)
        {
            WebClient net = new WebClient();
            byte[] data = net.DownloadData(link);
            MemoryStream content = new MemoryStream(data);

            string contentType = "APPLICATION/octet-stream";
            string fileName = "download.zip";
            var file = new FileParsed { Content = content, ContentType = contentType, FileName = fileName };

            return file;
        }
    }
}
