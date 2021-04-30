using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Base;

namespace WeLearn.Data.Models
{
    public class Comment : BaseModel
    {
        public int CommentId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
