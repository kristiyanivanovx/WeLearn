using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WeLearn.Data.Models.Base;

namespace WeLearn.Data.Models
{
    public class Video : BaseModel
    {
        public int VideoId { get; set; }

        [Required]
        [MaxLength(250)]
        public string VideoName { get; set; }

        [Required]
        public string VideoContentType { get; set; }

        [Required]
        [MaxLength(250)]
        public string Link { get; set; }

        //public int PostId { get; set; }

        //public Post Post { get; set; }
    }
}
