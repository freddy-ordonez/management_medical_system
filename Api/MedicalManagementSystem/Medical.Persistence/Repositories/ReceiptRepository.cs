using Medical.Domain.Entities;
using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence.Repositories
{
    public class ReceiptRepository : RepositoryBase<Receipt>, IReceiptRepository
    {
        public ReceiptRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public void CreateReceipt(Receipt receipt) => Create(receipt);

        public void DeleteReceipt(Receipt receipt) => Delete(receipt);

        public async Task<IEnumerable<Receipt>> FindAllReceiptAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .ToListAsync();

        public async Task<Receipt?> FindReceiptByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(r => r.ReceiptID.Equals(id), trackChanges)
                    .SingleOrDefaultAsync();            
    }
}
