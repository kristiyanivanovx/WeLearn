using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Models.Enums;
using WeLearn.Infrastructure.Interfaces;

namespace WeLearn.Infrastructure.ViewModels
{
    public class LessonEditModel : ILessonModel
    {
        public string UserId { get; set; }

        public int LessonId { get; set; }

        [MaxLength(250)]
        [Display(Name = "Name")]
        public string LessonName { get; set; }

        [MaxLength(1500)]
        [Display(Name = "Description")]
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
