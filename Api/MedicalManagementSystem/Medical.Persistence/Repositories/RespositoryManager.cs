using Medical.Domain.Repositories;

namespace Medical.Persistence.Repositories
{
    public class RespositoryManager : IRepositoryManager
    {
        private readonly ApplicationContext _context;
        private readonly Lazy<IAppointmentRepository> _appointmentRepository;
        private readonly Lazy<IDoctorRepository> _doctorRepository;
        private readonly Lazy<IDoctorSpecialityRepository> _doctorSpecialityRepository;
        private readonly Lazy<INotificationRepository> _notificationRepository;
        private readonly Lazy<IPatientRepository> _patientRepository;
        private readonly Lazy<IReceiptRepository> _receiptRepository;
        private readonly Lazy<IRoleRepository> _roleRepository;
        private readonly Lazy<ISpecialtyRepository> _specialtyRepository;
        private readonly Lazy<IUserRepository> _userRepository;

        public RespositoryManager(ApplicationContext applicationContext)
        {
            this._context = applicationContext;
            this._appointmentRepository = new Lazy<IAppointmentRepository>();
            this._doctorRepository = new Lazy<IDoctorRepository>();
            this._doctorSpecialityRepository = new Lazy<IDoctorSpecialityRepository>();
            this._notificationRepository = new Lazy<INotificationRepository>();
            this._patientRepository = new Lazy<IPatientRepository>();   
            this._receiptRepository = new Lazy<IReceiptRepository>();
            this._roleRepository = new Lazy<IRoleRepository>();
            this._specialtyRepository = new Lazy<ISpecialtyRepository>();
            this._userRepository = new Lazy<IUserRepository>();

        }

        public IAppointmentRepository AppointmentRepository => _appointmentRepository.Value;

        public IDoctorRepository DoctorRepository => _doctorRepository.Value;

        public IDoctorSpecialityRepository DoctorSpecialityRepository => _doctorSpecialityRepository.Value;

        public INotificationRepository NotificationRepository => _notificationRepository.Value;

        public IPatientRepository PatientRepository => _patientRepository.Value;

        public IReceiptRepository ReceiptRepository => _receiptRepository.Value;

        public IRoleRepository RoleRepository => _roleRepository.Value;

        public ISpecialtyRepository SpecialtyRepository => _specialtyRepository.Value;

        public IUserRepository UserRepository => _userRepository.Value;

        public Task SaveAsync() => _context.SaveChangesAsync();
    }
}
