﻿using System;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Models.Base;

using static WeLearn.Data.Infrastructure.DataValidation.Report;

namespace WeLearn.Data.Models
{
    public class Report : SoftDeleteable, IMetadataHaveable
    {
        [Required]
        [MaxLength(MaxSubjectLength)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int? LessonId { get; set; }

        public Lesson Lesson { get; set; }

        public int? CommentId { get; set; }

        public Comment Comment { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }
    }
}
