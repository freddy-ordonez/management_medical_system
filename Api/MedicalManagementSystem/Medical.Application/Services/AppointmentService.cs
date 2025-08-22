using AutoMapper;
using Medical.Application.Interfaces;
using Medical.Domain.Dto.Appointment;
using Medical.Domain.Entities;
using Medical.Domain.Entities.Exceptions;
using Medical.Domain.Repositories;

namespace Medical.Application.Services
{
    internal sealed class AppointmentService : IAppointmentService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public AppointmentService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<AppointmentDto> CreateAppointmentAsync(AppointmentForCreationDto appointmentForCreationDto)
        {
            var appointmentEntity = _mapper.Map<Appointment>(appointmentForCreationDto);

            _repositoryManager.AppointmentRepository
                .CreateAppoitment(appointmentEntity);
            await _repositoryManager.SaveAsync();

            var appointmentDto = _mapper.Map<AppointmentDto>(appointmentEntity);
            
            return appointmentDto;
        }

        public async Task DeleteAppointmentAsync(int appointmentId, bool trackChanges)
        {
            var appointmentEntity = await GetAppointmentAndCheckIfExistAsync(appointmentId, trackChanges);

            _repositoryManager.AppointmentRepository
                .DeleteAppointment(appointmentEntity);
            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<AppointmentDto>> GetAllAppointmentAsync(bool trackChanges)
        {
            var listAppointments = await _repositoryManager.AppointmentRepository
                .FindAllAppointmentAsync(trackChanges);

            var listAppointmentsDto = _mapper.Map<IEnumerable<AppointmentDto>>(listAppointments);
            
            return listAppointmentsDto;
        }

        public async Task<AppointmentDto> GetAppointmentByIdAsync(int appointmentId, bool trackChanges)
        {
            var appointmentEntity = await GetAppointmentAndCheckIfExistAsync(appointmentId, trackChanges);

            var appointmentDto = _mapper.Map<AppointmentDto>(appointmentEntity);

            return appointmentDto;
        }

        public async Task UpdateAppointmentAsync(AppointmentForUpdateDto appointmentForUpdateDto, int appointmentId, bool trackChanges)
        {
            var appointmentEntity = await GetAppointmentAndCheckIfExistAsync(appointmentId, trackChanges);

            _mapper.Map(appointmentForUpdateDto, appointmentEntity);

            await _repositoryManager.SaveAsync();
        }

        private Task<Appointment> GetAppointmentAndCheckIfExistAsync(int appointmentId, bool trackChanges)
        {
            var appointmentEntity = _repositoryManager.AppointmentRepository
                .FindAppointmentByIdAsync(appointmentId, trackChanges);

            return appointmentEntity is null ? throw new AppointmentNotFoundException(appointmentId) : appointmentEntity;
        }
    }
}
