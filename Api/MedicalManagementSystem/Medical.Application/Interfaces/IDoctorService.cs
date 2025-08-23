using Medical.Domain.Dto.Doctor;

namespace Medical.Application.Interfaces
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorDto>> GetAllDoctorsAsync(bool trackChanges);
        Task<DoctorDto> GetDoctorByIdAsync(int doctorId, bool trackChanges);
        Task<DoctorDto> CreateDoctor(DoctorDto doctorDto);
        Task UpdateDoctor(DoctorDto doctorDto, int doctorId, bool trackChanges);
        Task DeleteDoctor(int doctorId, bool trackChanges);
    }
}
