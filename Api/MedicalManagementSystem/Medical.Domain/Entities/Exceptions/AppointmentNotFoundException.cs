namespace Medical.Domain.Entities.Exceptions
{
    public class AppointmentNotFoundException : NotFoundException
    {
        public AppointmentNotFoundException(int id) : base($"La cita con id: {id} no se encuentra en el sistema...")
        {
        }
    }
}
