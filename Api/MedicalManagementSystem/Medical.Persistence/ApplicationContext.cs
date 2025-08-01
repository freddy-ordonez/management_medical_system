using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Receipt> Billings { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
