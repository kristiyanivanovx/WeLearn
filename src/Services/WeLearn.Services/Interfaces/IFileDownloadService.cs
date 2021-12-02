using WeLearn.Services.HelperModels;

namespace WeLearn.Services.Interfaces
{
    public interface IFileDownloadService
    {
        FileDownload DownloadFile(string link);
    }
}
