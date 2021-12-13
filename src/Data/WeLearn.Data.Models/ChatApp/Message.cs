using static WeLearn.Data.Common.Validation.DataValidation.Message;

using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Common.Models;

namespace WeLearn.Data.Models.ChatApp
{
    public class Message : BaseModel<int>
    {
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxMessageLength)]
        public string Text { get; set; }

        public int ChatId { get; set; }

        public Chat Chat { get; set; }
    }
}
