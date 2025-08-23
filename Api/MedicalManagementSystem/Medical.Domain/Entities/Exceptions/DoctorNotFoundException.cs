namespace Medical.Domain.Entities.Exceptions
{
    public class DoctorNotFoundException : NotFoundException
    {
        public DoctorNotFoundException(int doctorId) : base($"El doctor con id: {doctorId} no se encuentra en el sistema...")
        {
        }
    }
}
