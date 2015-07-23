using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineDoctor.Models
{
    public class OnlineDoctorContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Chamber> Chambers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Patient> Patients { get; set; }

    }
}