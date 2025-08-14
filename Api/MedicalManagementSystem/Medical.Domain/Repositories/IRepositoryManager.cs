namespace Medical.Domain.Repositories
{
    public interface IRepositoryManager
    {
        IAppointmentRepository AppointmentRepository { get; }
        IDoctorRepository DoctorRepository { get; }
        IDoctorSpecialityRepository DoctorSpecialityRepository { get; }
        INotificationRepository NotificationRepository { get; }
        IReceiptRepository PatientRepository { get; }
        IReceiptRepository ReceiptRepository { get; }
        IRoleRepository RoleRepository { get; }
        ISpecialtyRepository SpecialtyRepository { get; }
        IUserRepository UserRepository { get; }

        Task SaveAsync();
    }
}
