using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingManagementSystem.Data;
using TrainingManagementSystem.Models;

namespace TrainingManagementSystem.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly TrainingManagementContext _context;

        public CourseRepository(TrainingManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await _context.Courses.FindAsync(id);
        }

        public async Task<Course> AddCourseAsync(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<Course> UpdateCourseAsync(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<bool> DeleteCourseAsync(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
                return false;

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return true;
        }
    }

    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseByIdAsync(int id);
        Task<Course> AddCourseAsync(Course course);
        Task<Course> UpdateCourseAsync(Course course);
        Task<bool> DeleteCourseAsync(int id);
    }
}
