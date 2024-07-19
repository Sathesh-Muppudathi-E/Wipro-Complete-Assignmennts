using System;

namespace TrainingManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  // Initialized to avoid null reference
        public string Description { get; set; } = string.Empty;  // Initialized to avoid null reference
        public string Category { get; set; } = string.Empty;  // Initialized to avoid null reference
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = string.Empty;  // Initialized to avoid null reference
    }
}
