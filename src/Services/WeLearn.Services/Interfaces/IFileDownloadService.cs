using WeLearn.Data.Models.InputOutput;

namespace WeLearn.Services.Interfaces
{
    public interface IFileDownloadService
    {
        FileDownload DownloadFile(string link);
    }
}
