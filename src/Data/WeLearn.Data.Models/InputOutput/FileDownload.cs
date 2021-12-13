using System.IO;

namespace WeLearn.Data.Models.InputOutput
{
    public class FileDownload
    {
        public MemoryStream Content { get; set; }

        public string ContentType { get; set; }

        public string FileName { get; set; }
    }
}
