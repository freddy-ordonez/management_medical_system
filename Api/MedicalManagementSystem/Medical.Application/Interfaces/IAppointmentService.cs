using Medical.Domain.Dto.Appointment;

namespace Medical.Application.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentDto>> GetAllAppointmentAsync(bool trackChanges);
        Task<AppointmentDto> GetAppointmentByIdAsync(int appointmentId, bool trackChanges);
        Task<AppointmentDto> CreateAppointmentAsync(AppointmentForCreationDto appointmentForCreationDto);
        Task UpdateAppointmentAsync(AppointmentForUpdateDto appointmentForUpdateDto, int appointmentId, bool trackChanges);
        Task DeleteAppointmentAsync(int appointmentId, bool trackChanges);
    }
}
