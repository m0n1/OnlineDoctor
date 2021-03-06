﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineDoctor.Models
{
    public class ChamberTimeTable
    {
        public int  ChamberTimeTableId { get; set; }
        public int DoctorId { get; set; }
        public int ChamberId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public DayOfWeek Day { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Chamber Chamber { get; set; }
    }
}
