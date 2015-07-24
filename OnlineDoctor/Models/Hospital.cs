using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineDoctor.Models
{
    public class Hospital : ServiceCenter
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
    }
}