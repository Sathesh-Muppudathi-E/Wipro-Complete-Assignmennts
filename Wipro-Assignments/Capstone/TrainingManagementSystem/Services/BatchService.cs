using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories;

namespace TrainingManagementSystem.Services
{
    public class BatchService : IBatchService
    {
        private readonly IBatchRepository _batchRepository;

        public BatchService(IBatchRepository batchRepository)
        {
            _batchRepository = batchRepository;
        }

        public async Task<IEnumerable<Batch>> GetAllBatchesAsync()
        {
            return await _batchRepository.GetAllBatchesAsync();
        }

        public async Task<Batch> GetBatchByIdAsync(int id)
        {
            return await _batchRepository.GetBatchByIdAsync(id);
        }

        public async Task AddBatchAsync(Batch batch)
        {
            await _batchRepository.AddBatchAsync(batch);
        }

        public async Task UpdateBatchAsync(Batch batch)
        {
            await _batchRepository.UpdateBatchAsync(batch);
        }

        public async Task DeleteBatchAsync(int id)
        {
            await _batchRepository.DeleteBatchAsync(id);
        }
    }

    public interface IBatchService
    {
        Task<IEnumerable<Batch>> GetAllBatchesAsync();
        Task<Batch> GetBatchByIdAsync(int id);
        Task AddBatchAsync(Batch batch);
        Task UpdateBatchAsync(Batch batch);
        Task DeleteBatchAsync(int id);
    }
}
