using Medical.Domain.Entities;
using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence.Repositories
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }


        public async Task<IEnumerable<Appointment?>> FindAllAppointmentAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .ToListAsync();

        public async Task<Appointment?> FindAppointmentByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(a => a.AppointmentID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();
        public void CreateAppoitment(Appointment appointment) => Create(appointment);

        public void DeleteAppointment(Appointment appointment) => Delete(appointment);
    }
}
