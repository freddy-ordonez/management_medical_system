using Medical.Domain.Entities;

namespace Medical.Domain.Repositories
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<Appointment?>> FindAllAppointmentAsync(bool trackChanges);
        Task<Appointment?> FindAppointmentByIdAsync(int id, bool trackChanges);
        void CreateAppoitment(Appointment appointment);
        void DeleteAppointment(Appointment appointment);

    }
}
