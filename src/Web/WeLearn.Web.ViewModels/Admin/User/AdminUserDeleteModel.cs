using System;
using System.ComponentModel.DataAnnotations;

namespace WeLearn.ViewModels.Admin.User
{
    public class AdminUserDeleteModel
    {
        public string Id { get; set; }
        
        public string Email { get; set; }

        public string UserName { get; set; }

        public bool IsAdministrator { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }
    }
}
