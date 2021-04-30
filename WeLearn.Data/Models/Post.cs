using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Base;
using WeLearn.Data.Models.Enums;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Data.Models
{
    public class Post : BaseModel, ISoftDeleteable
    {
        public int PostId { get; set; }

        [Required]
        [MaxLength(250)]
        public string PostName { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public Grade Grade { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public bool IsDeleted { get; set; }

        public int VideoId { get; set; }

        public Video Video { get; set; }

        public int MaterialId { get; set; }

        public Material Material { get; set; }
    }
}
