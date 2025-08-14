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
            this._appointmentRepository = new Lazy<IAppointmentRepository>(new AppointmentRepository(_context));
            this._doctorRepository = new Lazy<IDoctorRepository>(new DoctorRepository(_context));
            this._doctorSpecialityRepository = new Lazy<IDoctorSpecialityRepository>(new DoctorSpecialityRepository(_context));
            this._notificationRepository = new Lazy<INotificationRepository>(new NotificationRepository(_context));
            this._patientRepository = new Lazy<IPatientRepository>( new PatientRepository(_context));   
            this._receiptRepository = new Lazy<IReceiptRepository>( new ReceiptRepository(_context));
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
