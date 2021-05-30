using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeLearn.ViewModels
{
	public class ContactsInputModel
	{
		[Required]
		[Display(Name = "Your email")]
		public string To { get; set; }

		[Required]
		public string Subject { get; set; }

		[Required]
		public string Content { get; set; }
	}
}
