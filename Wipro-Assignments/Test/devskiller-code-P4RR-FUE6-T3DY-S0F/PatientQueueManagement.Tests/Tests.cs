using NUnit.Framework;

namespace PatientQueueManagement.Tests
{
    [TestFixture]
    public class PatientQueueTests
    {
        [Test]
        public void RemovePatient_FromEmptyQueue_ReturnsNull()
        {
            // Arrange
            var patientQueue = new PatientQueue();

            // Act
            var removedPatient = patientQueue.RemovePatient();

            // Assert
            Assert.IsNull(removedPatient);
        }

        [Test]
        public void SearchMiddlePatient_OddNumberOfPatients_Success()
        {
            // Arrange
            var patientQueue = new PatientQueue();
            patientQueue.AddPatient(new Patient("John Doe", 30, "Fever"));
            patientQueue.AddPatient(new Patient("Jane Smith", 40, "Headache"));
            patientQueue.AddPatient(new Patient("Alice Johnson", 50, "Back Pain"));

            // Act
            var middlePatient = patientQueue.SearchMiddlePatient();

            // Assert
            Assert.IsNotNull(middlePatient);
            Assert.That(middlePatient.Name, Is.EqualTo("Jane Smith"));
            Assert.That(middlePatient.Age, Is.EqualTo(40));
            Assert.That(middlePatient.MedicalCondition, Is.EqualTo("Headache"));
        }

        [Test]
        public void SearchMiddlePatient_EvenNumberOfPatients_Success()
        {
            // Arrange
            var patientQueue = new PatientQueue();
            patientQueue.AddPatient(new Patient("John Doe", 30, "Fever"));
            patientQueue.AddPatient(new Patient("Jane Smith", 40, "Headache"));
            patientQueue.AddPatient(new Patient("Alice Johnson", 50, "Back Pain"));
            patientQueue.AddPatient(new Patient("Michael Brown", 60, "Cough"));

            // Act
            var middlePatient = patientQueue.SearchMiddlePatient();

            // Assert
            Assert.IsNotNull(middlePatient);
            Assert.That(middlePatient.Name, Is.EqualTo("Alice Johnson"));
            Assert.That(middlePatient.Age, Is.EqualTo(50));
            Assert.That(middlePatient.MedicalCondition, Is.EqualTo("Back Pain"));
        }


        [Test]
        public void SearchMiddlePatient_EmptyQueue_ReturnsNull()
        {
            // Arrange
            var patientQueue = new PatientQueue();

            // Act
            var middlePatient = patientQueue.SearchMiddlePatient();

            // Assert
            Assert.IsNull(middlePatient);
        }
    }
}