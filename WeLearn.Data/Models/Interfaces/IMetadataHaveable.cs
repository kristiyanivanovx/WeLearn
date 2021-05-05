using System;

namespace WeLearn.Data.Models.Interfaces
{
    public interface IMetadataHaveable 
    {
        public DateTime DateCreated { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}
