using Medical.Domain.Entities;

namespace Medical.Domain.Repositories
{
    public interface INotificationRepository
    {
        Task<IEnumerable<Notification>> FindAllNotificationAsync(bool trackChages);
        void CreateNotification(Notification notification);
        void DeleteNotification(Notification notification);
    }
}
