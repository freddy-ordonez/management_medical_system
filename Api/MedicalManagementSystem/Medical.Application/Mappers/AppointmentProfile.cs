using AutoMapper;
using Medical.Domain.Dto.Appointment;
using Medical.Domain.Entities;

namespace Medical.Application.Mappers
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile() 
        { 
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
            CreateMap<Appointment, AppointmentForCreationDto>().ReverseMap();
            CreateMap<Appointment, AppointmentForUpdateDto>().ReverseMap();
        }
    }
}
