namespace WeLearn.Data.Models.Interfaces
{
    public class SoftDeleteable : Identifiable
    {
        public bool IsDeleted { get; set; }
    }
}
