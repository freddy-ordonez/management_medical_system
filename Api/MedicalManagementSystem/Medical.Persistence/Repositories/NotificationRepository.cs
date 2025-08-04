using Medical.Domain.Entities;
using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence.Repositories
{
    public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
    {
        public NotificationRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public void CreateNotification(Notification notification) => Create(notification);

        public void DeleteNotification(Notification notification) => Delete(notification);

        public async Task<IEnumerable<Notification>> FindAllNotificationAsync(bool trackChages) =>
            await FindAll(trackChages)
                    .Include(n => n.Appointment)
                        .ThenInclude(a => a.Patient)
                    .ToListAsync();
    }
}
