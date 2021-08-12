using System;

namespace WeLearn.ViewModels.Message
{
    public class PrivateMessageIndexViewModel
    {
        public string Text { get; set; }

        public string OtherCorrespondent { get; set; }

        public DateTime DateCreated { get; set; }
    }
}