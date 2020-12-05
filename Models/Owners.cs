using System;
using System.Collections.Generic;

namespace ClinicApp.Models
{
    public partial class Owners
    {
        public Owners()
        {
            Animals = new HashSet<Animals>();
            OwnersServices = new HashSet<OwnersServices>();
        }

        public int Id { get; set; }
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }
        public string OwnerLastname { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Animals> Animals { get; set; }
        public virtual ICollection<OwnersServices> OwnersServices { get; set; }
    }
}
