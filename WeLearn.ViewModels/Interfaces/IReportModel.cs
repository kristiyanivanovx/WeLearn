namespace WeLearn.ViewModels.Interfaces
{
    public interface IReportModel
    {
        public int OriginId { get; set; }

        public string ReportingUserId { get; set; }

        public string Subject { get; set; }

        public string ReportDescription { get; set; }

        public string OriginApplicationUserUserName { get; set; }
    }
}
