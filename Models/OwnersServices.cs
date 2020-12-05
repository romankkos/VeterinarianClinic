using System;
using System.Collections.Generic;

namespace ClinicApp.Models
{
    public partial class OwnersServices
    {
        public int Id { get; set; }
        public int? OwnerId { get; set; }
        public int? ServiceId { get; set; }

        public virtual Owners Owner { get; set; }
        public virtual Services Service { get; set; }
    }
}
