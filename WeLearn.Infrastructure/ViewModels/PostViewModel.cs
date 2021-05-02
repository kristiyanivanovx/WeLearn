using WeLearn.Data.Models.Enums;

namespace WeLearn.Infrastructure.ViewModels
{
    public class PostViewModel
    {
        public int PostId { get; set; }

        public string PostName { get; set; }

        public string Description { get; set; }

        public Grade Grade { get; set; }

        public string CategoryName { get; set; }

        public string CreatedByUserName { get; set; }

        public string VideoName { get; set; }

        public string VideoContentType { get; set; }

        public string VideoLink { get; set; }

        public string ZippedFile { get; set; }
    }
}
