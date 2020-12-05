using System;
using System.Collections.Generic;

namespace ClinicApp.Models
{
    public partial class Animals
    {
        public Animals()
        {
            AnimalsVactination = new HashSet<AnimalsVactination>();
        }

        public int Id { get; set; }
        public string AnimalName { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public int? VeterinarianId { get; set; }
        public int? OwnerId { get; set; }

        public virtual Owners Owner { get; set; }
        public virtual Veterinarian Veterinarian { get; set; }
        public virtual ICollection<AnimalsVactination> AnimalsVactination { get; set; }
    }
}
