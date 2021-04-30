using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WeLearn.Data.Models.Base;

namespace WeLearn.Data.Models
{
    public class Material : BaseModel
    {
        public int MaterialId { get; set; }

        [Required]
        [MaxLength(250)]
        public string MaterialName { get; set; }

        [Required]
        [MaxLength(250)]
        public string Link { get; set; }

        //public int PostId { get; set; }

        //public Post Post { get; set; }
    }
}
