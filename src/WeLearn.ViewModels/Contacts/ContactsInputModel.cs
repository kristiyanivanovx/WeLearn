using System.ComponentModel.DataAnnotations;

namespace WeLearn.ViewModels.Contacts
{
    public class ContactsInputModel
	{
		[Required]
		[MaxLength(200)]
		[Display(Name = "Your name")]
		public string FromName { get; set; }

		[Required]
		[Display(Name = "Your email")]
		[EmailAddress]
		public string FromEmail { get; set; }

		[Required]
		[MaxLength(500)]
		public string Subject { get; set; }

		[Required]
		[MaxLength(3500)]
		public string Content { get; set; }
	}
}
