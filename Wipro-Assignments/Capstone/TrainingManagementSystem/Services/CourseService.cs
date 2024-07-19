using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories;

namespace TrainingManagementSystem.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _courseRepository.GetAllCoursesAsync();
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await _courseRepository.GetCourseByIdAsync(id);
        }

        public async Task<Course> AddCourseAsync(Course course)
        {
            return await _courseRepository.AddCourseAsync(course);
        }

        public async Task<Course> UpdateCourseAsync(Course course)
        {
            return await _courseRepository.UpdateCourseAsync(course);
        }

        public async Task<bool> DeleteCourseAsync(int id)
        {
            return await _courseRepository.DeleteCourseAsync(id);
        }
    }

    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseByIdAsync(int id);
        Task<Course> AddCourseAsync(Course course);
        Task<Course> UpdateCourseAsync(Course course);
        Task<bool> DeleteCourseAsync(int id);
    }
}
