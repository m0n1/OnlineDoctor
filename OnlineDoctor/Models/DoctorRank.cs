using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineDoctor.Models
{
    public class DoctorRank
    {
        public int DoctorRankId { get; set; }
        public int UserCount { get; set; }
        public int RankValue { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}