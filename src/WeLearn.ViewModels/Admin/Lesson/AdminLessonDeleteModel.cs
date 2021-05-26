using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data.Models.Enums;

namespace WeLearn.ViewModels.Admin.Lesson
{
    public class AdminLessonDeleteModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public Grade Grade { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }

        public string CategoryName { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }
        
        [Display(Name = "Is approved")]
        public bool IsApproved { get; set; }

        public string ApplicationUserUserName { get; set; }

        public string VideoName { get; set; }

        public string VideoContentType { get; set; }

        public string VideoLink { get; set; }

        public string MaterialLink { get; set; }
    }
}
