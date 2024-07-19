using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegistrationForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var registrationDetail = new RegistrationDetail
            {
                FirstName = FirstNameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Gender = (GenderComboBox.SelectedItem as ComboBoxItem)?.Content.ToString(),
                ContactNo = ContactNoTextBox.Text,
                DateOfBirth = DateOfBirthPicker.SelectedDate ?? DateTime.Now,
                Country = (CountryComboBox.SelectedItem as ComboBoxItem)?.Content.ToString(),
                State = (StateComboBox.SelectedItem as ComboBoxItem)?.Content.ToString(),
                City = (CityComboBox.SelectedItem as ComboBoxItem)?.Content.ToString()
            };

            using (var context = new RegistrationContext())
            {
                context.RegistrationDetails.Add(registrationDetail);
                context.SaveChanges();
            }

            MessageBox.Show("Registration successful!");
        }
    }
}