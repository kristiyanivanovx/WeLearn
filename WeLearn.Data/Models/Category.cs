using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Base;

namespace WeLearn.Data.Models
{
    public class Category : BaseModel
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }

        public int CategoryId { get; set; }

        [Required]
        [MaxLength(250)]
        public string CategoryName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
