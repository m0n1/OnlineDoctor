using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineDoctor.Models
{
    public class Doctor: ApplicationUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public virtual ICollection<Qualification> Qualifications { get; set; }
        public string RegistrationNo { get; set; }
        public virtual Specialization Specialization { get; set; }
        public virtual ICollection<ServiceCenter> ServiceCenters  { get; set; }
        public virtual List<ChamberTimeTable> AvailableTimeTable { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual DoctorRank DoctorRank { get; set; }
        
    }
}