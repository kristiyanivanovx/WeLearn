using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Base;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Data.Models
{
    public class Report : BaseModel, ISoftDeleteable
    {
        public int ReportId { get; set; }

        [Required]
        [MaxLength(250)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int? PostId { get; set; }

        public Post Post { get; set; }

        public int? CommentId { get; set; }

        public Comment Comment { get; set; }

        public DateTime? DateResolved { get; set; }

        public bool IsResolved { get; set; } = false;

        public bool IsDeleted { get; set; } = false;
    }
}
