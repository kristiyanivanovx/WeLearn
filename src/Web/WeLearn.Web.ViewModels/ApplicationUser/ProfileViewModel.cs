using System;
using Microsoft.AspNetCore.Http;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.ApplicationUser
{
    public class ProfileViewModel : IMapFrom<Data.Models.Identity.ApplicationUser>
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string ProfileImageUrl { get; set; }

        public DateTime MemberSince { get; set; }

        public IFormFile ImageUpload { get; set; }
    }
}
