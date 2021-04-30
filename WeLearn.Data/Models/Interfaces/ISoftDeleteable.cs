namespace WeLearn.Data.Models.Interfaces
{
    public interface ISoftDeleteable
    {
        public bool IsDeleted { get; set; }
    }
}
