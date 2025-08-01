using Medical.Domain.Entities;
using Medical.Persistence.Configuration;
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
            EntityConfiguration(modelBuilder);
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


        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new AppointmentConfiguration(modelBuilder.Entity<Appointment>());
            new RoleConfiguration(modelBuilder.Entity<Role>());
            new DoctorConfiguration(modelBuilder.Entity<Doctor>());
            new DoctorSpecialtyConfiguration(modelBuilder.Entity<DoctorSpecialty>());
            new NotificationConfiguration(modelBuilder.Entity<Notification>());
            new PatientConfiguration(modelBuilder.Entity<Patient>());
            new ReceiptConfiguration(modelBuilder.Entity<Receipt>());
            new SpecialtyConfiguration(modelBuilder.Entity<Specialty>());
            new UserConfiguration(modelBuilder.Entity<User>());
        }
    }
}
