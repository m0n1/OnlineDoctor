using System.Collections.Generic;


namespace OnlineDoctor.Models
{
    public class Chamber : ServiceCenter
    {
        public int ChamberId { get; set; }
        public string ChamberName { get; set; }
        public virtual List<ChamberTimeTable> AvailableTimeTable { get; set; }
    }
}
