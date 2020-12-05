using System;
using System.Collections.Generic;

namespace ClinicApp.Models
{
    public partial class Services
    {
        public Services()
        {
            OwnersServices = new HashSet<OwnersServices>();
        }

        public int Id { get; set; }
        public string ServiceName { get; set; }
        public double Price { get; set; }

        public virtual ICollection<OwnersServices> OwnersServices { get; set; }
    }
}
