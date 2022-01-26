using WeLearn.Data.Models.InputOutput;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IFileDownloadService
    {
        FileDownload DownloadFile(string link);
    }
}
