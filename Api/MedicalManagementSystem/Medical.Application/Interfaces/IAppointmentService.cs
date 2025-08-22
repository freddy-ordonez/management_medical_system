using Medical.Domain.Dto.Appointment;

namespace Medical.Application.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentDto>> GetAllAppointmentAsync(bool trackChanges);
        Task<AppointmentDto> GetAppointmentByIdAsync(int appointmentId, bool trackChanges);
        Task CreateAppointmentAsync(AppointmentForCreationDto appointmentForCreationDto);
        Task DeleteAppointmentAsync(int appointmentId, bool trackChanges);
    }
}
