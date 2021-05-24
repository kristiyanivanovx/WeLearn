using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Enums;
using WeLearn.ViewModels.Interfaces;
using static WeLearn.Data.DataValidation.Lesson;

namespace WeLearn.ViewModels.Lesson
{
    public class LessonEditModel : ILessonModel
    {
        public string UserId { get; set; }

        public int LessonId { get; set; }

        [Display(Name = "Name")]
        [MaxLength(MaxNameLength)]
        public string LessonName { get; set; }

        [Display(Name = "Description")]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public Grade Grade { get; set; }

        public string OldVideoLink { get; set; }

        public string OldVideoContentType { get; set; }

        public string OldFilesLink { get; set; }

        public IFormFile Video { get; set; }
        
        public IEnumerable<IFormFile> Files { get; set; }
    }
}
