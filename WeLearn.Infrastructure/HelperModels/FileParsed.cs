using System.IO;

namespace WeLearn.Infrastructure.HelperModels
{
    public class FileParsed
    {
        public MemoryStream Content { get; set; }

        public string ContentType { get; set; }

        public string FileName { get; set; }
    }
}
