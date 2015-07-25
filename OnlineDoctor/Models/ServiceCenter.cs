using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineDoctor.Models
{
    public abstract class ServiceCenter
    {
        public int ServiceCenterId { get; set; }
        public string ServiceCenterName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public virtual Area Area { get; set; }
    }
}