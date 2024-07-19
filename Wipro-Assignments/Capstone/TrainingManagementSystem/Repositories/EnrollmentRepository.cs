using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingManagementSystem.Data;
using TrainingManagementSystem.Models;


namespace TrainingManagementSystem.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly TrainingManagementContext _context;

        public EnrollmentRepository(TrainingManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Enrollment>> GetAllEnrollmentsAsync()
        {
            return await _context.Enrollments
                .Include(e => e.User)
                .Include(e => e.Course)
                .ToListAsync();
        }

        public async Task<Enrollment> GetEnrollmentByIdAsync(int id)
        {
            return await _context.Enrollments
                .Include(e => e.User)
                .Include(e => e.Course)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Enrollment> CreateEnrollmentAsync(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();
            return enrollment;
        }

        public async Task<bool> UpdateEnrollmentStatusAsync(int id, string status)
        {
            var enrollment = await _context.Enrollments.FindAsync(id);
            if (enrollment == null) return false;

            enrollment.Status = status;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteEnrollmentAsync(int id)
        {
            var enrollment = await _context.Enrollments.FindAsync(id);
            if (enrollment == null) return false;

            _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();
            return true;
        }
    }

    public interface IEnrollmentRepository
    {
        Task<IEnumerable<Enrollment>> GetAllEnrollmentsAsync();
        Task<Enrollment> GetEnrollmentByIdAsync(int id);
        Task<Enrollment> CreateEnrollmentAsync(Enrollment enrollment);
        Task<bool> UpdateEnrollmentStatusAsync(int id, string status);
        Task<bool> DeleteEnrollmentAsync(int id);
    }
}
