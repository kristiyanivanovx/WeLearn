namespace WeLearn.Infrastructure.Interfaces
{
    public interface IReportModel
    {
        public int PostId { get; set; }

        public string ReportingUserId { get; set; }

        public string Subject { get; set; }

        public string ReportDescription { get; set; }

        public string PostApplicationUserUserName { get; set; }

    }
}
