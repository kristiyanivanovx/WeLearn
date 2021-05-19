using System.IO;

namespace WeLearn.Services.HelperModels
{
    public class FileDownload
    {
        public MemoryStream Content { get; set; }

        public string ContentType { get; set; }

        public string FileName { get; set; }
    }
}
