using AutoMapper;
using Medical.Application.Interfaces;
using Medical.Domain.Dto.Doctor;
using Medical.Domain.Entities;
using Medical.Domain.Entities.Exceptions;
using Medical.Domain.Repositories;

namespace Medical.Application.Services
{
    internal sealed class DoctorService : IDoctorService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public DoctorService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<DoctorDto> CreateDoctor(DoctorDto doctorDto)
        {
            var doctorEntity = _mapper.Map<Doctor>(doctorDto);

            _repositoryManager.DoctorRepository
                .CreateDoctor(doctorEntity);

            await _repositoryManager.SaveAsync();

            return _mapper.Map<DoctorDto>(doctorEntity);
        }

        public async Task DeleteDoctor(int doctorId, bool trackChanges)
        {
            var doctorEntity = await GetDoctorAndCheckifExistAsync(doctorId, trackChanges);

            _repositoryManager.DoctorRepository
                .DeleteDoctor(doctorEntity);

            await _repositoryManager.SaveAsync();
        }

        public async Task<IEnumerable<DoctorDto>> GetAllDoctorsAsync(bool trackChanges)
        {
            var listDoctorEntities = await _repositoryManager.DoctorRepository
                .FindAllDoctorAsync(trackChanges);

            var listDoctorDto = _mapper.Map<IEnumerable<DoctorDto>>(listDoctorEntities);

            return listDoctorDto;
        }

        public async Task<DoctorDto> GetDoctorByIdAsync(int doctorId, bool trackChanges)
        {
            var doctorEntity = await GetDoctorAndCheckifExistAsync(doctorId, trackChanges);

            var doctorDto = _mapper.Map<DoctorDto>(doctorEntity);

            return doctorDto;
        }

        public async Task UpdateDoctor(DoctorDto doctorDto, int doctorId, bool trackChanges)
        {
            var doctorEntity = await GetDoctorAndCheckifExistAsync(doctorId, trackChanges);

            _mapper.Map(doctorDto, doctorEntity);

            await _repositoryManager.SaveAsync();
        }

        private Task<Doctor?> GetDoctorAndCheckifExistAsync(int doctorId, bool trackChanges)
        {
            var doctorEntity = _repositoryManager.DoctorRepository
                .FindByIddDoctor(doctorId, trackChanges);

            return doctorEntity is null ? throw new DoctorNotFoundException(doctorId) : doctorEntity; 
        }
    }
}
