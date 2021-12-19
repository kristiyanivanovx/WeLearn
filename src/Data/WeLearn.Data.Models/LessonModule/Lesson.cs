using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.Enums;
using WeLearn.Data.Models.Identity;
using WeLearn.Data.Models.Shared;

using static WeLearn.Data.Common.Validation.DataValidation.Lesson;

namespace WeLearn.Data.Models.LessonModule
{
    public class Lesson : BaseDeletableModel<int>
    {
        public Lesson()
        {
            this.Likes = new HashSet<Like>();
            this.Recommendations = new HashSet<Recommendation>();
        }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [Display(Name = "Is approved")]
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public Grade Grade { get; set; }

        public ICollection<Like> Likes { get; set; }

        public ICollection<Recommendation> Recommendations { get; set; }

        public string ApplicationUserId { get; set; }

        [Display(Name = "User")]
        public ApplicationUser ApplicationUser { get; set; }

        public int VideoId { get; set; }

        public Video Video { get; set; }

        public int MaterialId { get; set; }

        public Material Material { get; set; }
    }
}
