using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Base;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Data.Models
{
    public class Comment : BaseModel, ISoftDeleteable
    {
        public int CommentId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public bool IsDeleted { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
