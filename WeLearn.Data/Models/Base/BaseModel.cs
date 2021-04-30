using System;

namespace WeLearn.Data.Models.Base
{
    public abstract class BaseModel 
    {
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}
