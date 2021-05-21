using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data.Models.Enums;

namespace WeLearn.ViewModels
{
    public class AdministrationLessonModel 
    {
        public string CreatedByEmail { get; set; }

        public string CreatedById { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }
        
        [Display(Name = "Is approved")]
        public bool IsApproved { get; set; }

        public int LessonId { get; set; }

        [Display(Name = "Name")]
        public string LessonName { get; set; }

        public string Description { get; set; }

        public Grade Grade { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }

        public string CategoryName { get; set; }

        public string ApplicationUserUserName { get; set; }

        public string VideoName { get; set; }

        public string VideoContentType { get; set; }

        public string VideoLink { get; set; }

        public string MaterialLink { get; set; }
    }
}
