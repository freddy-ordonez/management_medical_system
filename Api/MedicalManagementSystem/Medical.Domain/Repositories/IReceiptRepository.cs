using Medical.Domain.Entities;

namespace Medical.Domain.Repositories
{
    public interface IReceiptRepository
    {
        Task<IEnumerable<Receipt>>? FindAllReceiptAsync(bool trackChanges);
        Task<Receipt>? FindReceiptByIdAsync(int id, bool trackChanges);
        void CreateReceipt(Receipt receipt);
        void DeleteReceipt(Receipt receipt);
    }
}
