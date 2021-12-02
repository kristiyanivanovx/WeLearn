using System;

namespace WeLearn.Web.ViewModels.Message
{
    public class PrivateMessageIndexViewModel
    {
        public string Text { get; set; }

        public string OtherCorrespondent { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}