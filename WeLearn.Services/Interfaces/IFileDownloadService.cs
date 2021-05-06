using WeLearn.Infrastructure.HelperModels;

namespace WeLearn.Services.Interfaces
{
    public interface IFileDownloadService
    {
        FileDownload DownloadFile(string link);
    }
}
