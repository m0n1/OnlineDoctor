using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineDoctor.Models
{
    public class Doctor: ApplicationUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        public string RegistrationNo { get; set; }
        public virtual Specialization Specialization { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual List<ChamberTimeTable> AvailableTimeTable { get; set; }

        
    }
}