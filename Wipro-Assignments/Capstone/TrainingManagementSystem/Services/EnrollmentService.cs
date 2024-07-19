using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories;

namespace TrainingManagementSystem.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentService(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<IEnumerable<Enrollment>> GetAllEnrollmentsAsync()
        {
            return await _enrollmentRepository.GetAllEnrollmentsAsync();
        }

        public async Task<Enrollment> GetEnrollmentByIdAsync(int id)
        {
            return await _enrollmentRepository.GetEnrollmentByIdAsync(id);
        }

        public async Task<Enrollment> CreateEnrollmentAsync(Enrollment enrollment)
        {
            return await _enrollmentRepository.CreateEnrollmentAsync(enrollment);
        }

        public async Task<bool> UpdateEnrollmentStatusAsync(int id, string status)
        {
            return await _enrollmentRepository.UpdateEnrollmentStatusAsync(id, status);
        }

        public async Task<bool> DeleteEnrollmentAsync(int id)
        {
            return await _enrollmentRepository.DeleteEnrollmentAsync(id);
        }
    }

    public interface IEnrollmentService
    {
        Task<IEnumerable<Enrollment>> GetAllEnrollmentsAsync();
        Task<Enrollment> GetEnrollmentByIdAsync(int id);
        Task<Enrollment> CreateEnrollmentAsync(Enrollment enrollment);
        Task<bool> UpdateEnrollmentStatusAsync(int id, string status);
        Task<bool> DeleteEnrollmentAsync(int id);
    }
}
