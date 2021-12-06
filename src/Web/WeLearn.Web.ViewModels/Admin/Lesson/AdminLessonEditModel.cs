using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Category;

namespace WeLearn.Web.ViewModels.Admin.Lesson
{
    public class AdminLessonEditModel : IMapFrom<Data.Models.Lesson>
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }

        [Display(Name = "Is approved")]
        public bool IsApproved { get; set; }

        public Grade Grade { get; set; }

        [Display(Name = "Date created")]
        public DateTime CreatedOn { get; set; }

        public string VideoName { get; set; }

        public string VideoContentType { get; set; }

        public string VideoLink { get; set; }

        public string MaterialLink { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
