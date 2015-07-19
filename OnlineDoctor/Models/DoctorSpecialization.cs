using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineDoctor.Models
{
    public class DoctorSpecialization
    {
        public int DoctorSpecializationId { get; set; }
        public Doctor Doctor { get; set; }
        public Specialization Specialization { get; set; }
    }
}