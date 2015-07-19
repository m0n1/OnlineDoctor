using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineDoctor.Models
{
    public class Specialization
    {
        public int SpecializationId { get; set; }
        public string SpecializationName { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }

    }
}
