using System.Threading.Tasks;

using WeLearn.Web.ViewModels.Message;

namespace WeLearn.Services.Interfaces
{
    public interface IPrivateMessageService
    {
        AllPrivateMessagesViewModel<PrivateMessageConversationViewModel> CreateConversationViewModel(string correspondent, string currentUserName, string currentUserId);

        Task CreatePrivateMessageAsync(PrivateMessageInputModel model, string currentUserId);

        AllPrivateMessagesViewModel<PrivateMessageIndexViewModel> CreateIndexViewModel(string currentUsername, string currentUserId);
    }
}
