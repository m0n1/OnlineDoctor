using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using OnlineDoctor.Models.EnumHelper;

namespace OnlineDoctor.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NationalIdNo { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public virtual Area Area { get; set; }
        public Gender Gender { get; set; }
        public string Occupation { get; set; }
        public int CityId { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public bool IsActive { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(): base("DefaultConnection")
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<ServiceCenter> ServiceCenters { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}