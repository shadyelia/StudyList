using System;

namespace Entities.Entites
{
    public class BaseEntity
    {
        public DateTime? CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public string ModifiedBy { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
