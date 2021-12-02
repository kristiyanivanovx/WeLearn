using System;

namespace WeLearn.Web.ViewModels.Message
{
    public class PrivateMessageConversationViewModel
    {
        public string Text { get; set; }

        public string ReceiverId { get; set; }

        public string ReceiverUsername { get; set; }

        public string SenderUsername { get; set; }

        public string CurrentUsername { get; set; }

        public string ReplyTo { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
