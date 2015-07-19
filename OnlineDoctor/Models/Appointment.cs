using System;

namespace OnlineDoctor.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int SerialNo { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ServiceCenter ServiceCenter { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
    }
}