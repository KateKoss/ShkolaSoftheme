using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            birthDatePicker.DisplayDateStart = new DateTime(1901, 1, 1);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = string.Empty;            
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || !ValidationRules.ContainsOnlyLetter(firstNameTextBox.Text))
            {
                errorMessage += "First name must contain only letters\n";
            }
            if (string.IsNullOrEmpty(lastNameTextBox1.Text) || !ValidationRules.ContainsOnlyLetter(lastNameTextBox1.Text))
            {
                errorMessage += "Last name must contain only letters\n";
            }
            if (!birthDatePicker.SelectedDate.HasValue)
            {
                errorMessage += "Choose your birth date\n";
            }
            if (genderComboBox.SelectedIndex == -1)
            {
                errorMessage += "Choose gender\n";
            }
            if (!ValidationRules.CheckEmail(emailTextBox.Text))
            {
                errorMessage += "Email must be like example@gmail.com\n";
            }
            if (!ValidationRules.CheckPhoneNumber(phoneNumberTextBox.Text))
            {
                errorMessage += "Phone number must contains only digits. Length 12.";
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Registration is successful", "Success", MessageBoxButton.OK);
            }
            
        }

        

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        

        //private void firstNameTextBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (Char.IsLetter((char)e.Key))       //не работает!!
        //    {
        //        e.Handled = true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("First name must contain only letters", "First name error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}


    }
}
