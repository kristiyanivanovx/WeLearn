using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeLearn.ViewModels
{
    public class AdministrationLessonModel : LessonViewModel
    {
        public string CreatedByEmail { get; set; }

        public string CreatedById { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }
        
        [Display(Name = "Is approved")]
        public bool IsApproved { get; set; }
    }
}
