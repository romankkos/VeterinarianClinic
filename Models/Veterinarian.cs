using System;
using System.Collections.Generic;

namespace ClinicApp.Models
{
    public partial class Veterinarian
    {
        public Veterinarian()
        {
            Animals = new HashSet<Animals>();
        }

        public int Id { get; set; }
        public string VeterinarianName { get; set; }
        public string VeterinarianSurname { get; set; }
        public string VeterinarianLastname { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Animals> Animals { get; set; }
    }
}
