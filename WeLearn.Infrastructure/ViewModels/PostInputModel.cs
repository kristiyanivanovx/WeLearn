﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Enums;
using WeLearn.Infrastructure.Interfaces;

namespace WeLearn.Infrastructure.ViewModels
{
    public class PostInputModel : IPostModel
    {
        [MaxLength(250)]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please add name.")]
        public string PostName { get; set; }

        [MaxLength(1500)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please add description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please pick a category.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please pick a grade.")]
        public Grade Grade { get; set; }

        public string UserId { get; set; }

        [Required(ErrorMessage = "Please provide a video.")]
        public IFormFile Video { get; set; }

        [Required(ErrorMessage = "Please provide one or more files, related to the lesson.")]
        public IEnumerable<IFormFile> Files { get; set; }
    }
}
