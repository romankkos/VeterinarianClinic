using System;
using System.Collections.Generic;

namespace ClinicApp.Models
{
    public partial class AnimalsVactination
    {
        public int Id { get; set; }
        public int? AnimalId { get; set; }
        public int? VactinationId { get; set; }

        public virtual Animals Animal { get; set; }
        public virtual Vactination Vactination { get; set; }
    }
}
