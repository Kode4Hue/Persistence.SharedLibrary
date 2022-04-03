using NodaTime;
using System;

namespace Persistence.SharedLibrary.Domain
{
    public class EntityBase
    {
        public object Id { get; set; }

        public LocalDateTime CreatedAtUTC { get; set; }

        public string CreatedBy { get; set; }

        public LocalDateTime LastModifiedUTC { get; set; }

        public LocalDateTime LastModifiedBy { get; set; }
    }
}
