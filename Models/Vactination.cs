using System;
using System.Collections.Generic;

namespace ClinicApp.Models
{
    public partial class Vactination
    {
        public Vactination()
        {
            AnimalsVactination = new HashSet<AnimalsVactination>();
        }

        public int Id { get; set; }
        public string VactinationName { get; set; }

        public virtual ICollection<AnimalsVactination> AnimalsVactination { get; set; }
    }
}
