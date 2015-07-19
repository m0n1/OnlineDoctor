using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineDoctor.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Appointment Appointment { get; set; }
        public string Medication { get; set; }
        public string Test { get; set; }
        public string PrescriptionImage { get; set; }
        public string Remedy { get; set; }
    }
}