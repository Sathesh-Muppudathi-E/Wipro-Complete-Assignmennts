using Microsoft.EntityFrameworkCore;
using TrainingManagementSystem.Data;
using TrainingManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrainingManagementSystem.Repositories
{
    public class BatchRepository : IBatchRepository
    {
        private readonly TrainingManagementContext _context;

        public BatchRepository(TrainingManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Batch>> GetAllBatchesAsync()
        {
            return await _context.Batches.ToListAsync();
        }

        public async Task<Batch?> GetBatchByIdAsync(int id)
        {
            return await _context.Batches.FindAsync(id);
        }

        public async Task AddBatchAsync(Batch batch)
        {
            await _context.Batches.AddAsync(batch);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBatchAsync(Batch batch)
        {
            _context.Batches.Update(batch);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBatchAsync(int id)
        {
            var batch = await _context.Batches.FindAsync(id);
            if (batch != null)
            {
                _context.Batches.Remove(batch);
                await _context.SaveChangesAsync();
            }
        }
    }

    public interface IBatchRepository
    {
        Task<IEnumerable<Batch>> GetAllBatchesAsync();
        Task<Batch?> GetBatchByIdAsync(int id);
        Task AddBatchAsync(Batch batch);
        Task UpdateBatchAsync(Batch batch);
        Task DeleteBatchAsync(int id);
    }
}
