namespace TrainingManagementSystem.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public string Status { get; set; } = string.Empty;  // Initialized to avoid null reference

        // Navigation properties
        public User User { get; set; } = null!;  // Non-nullable reference
        public Course Course { get; set; } = null!;  // Non-nullable reference
    }
}
