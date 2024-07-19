using System;

namespace TrainingManagementSystem.Models
{
    public class Batch
    {
        public int ID { get; set; }
        public string Name { get; set; }  // Initialize to empty string
        public string Description { get; set; }  // Initialize to empty string
        public string Category { get; set; }  // Initialize to empty string
        public string Status { get; set; }  // Initialize to empty string
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
