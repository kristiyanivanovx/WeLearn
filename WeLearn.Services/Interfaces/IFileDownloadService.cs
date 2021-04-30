using WeLearn.Infrastructure.HelperModels;

namespace WeLearn.Services.Interfaces
{
    public interface IFileDownloadService
    {
        FileParsed DownloadFile(string link);
    }
}
