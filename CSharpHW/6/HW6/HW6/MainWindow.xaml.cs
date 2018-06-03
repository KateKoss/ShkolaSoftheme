using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace HW6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GenerationModule generator;
        int tryCounter = 3;
        public MainWindow()
        {
            InitializeComponent();
            generator = new GenerationModule();
            infoLabel.Content += "from " + generator.minValue + " to " + generator.maxValue;

        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int userGuessNumber = int.Parse(numberFromTextBox.Text);

                if (userGuessNumber> generator.maxValue || userGuessNumber < generator.minValue)
                {
                    throw new NumberExeption();
                }
                if (userGuessNumber == generator.number)
                {
                    MessageBox.Show("You guessed. Correct number is " + generator.number, "Guessed", MessageBoxButton.OK);
                    this.Close();
                }
                else
                {
                    if (tryCounter == 1)
                    {
                        tryCounter = 3;
                        generator = new GenerationModule();
                        MessageBox.Show("New number generated. Try again.\n" + tryCounter + " attempts left  ", "Not guessed", MessageBoxButton.OK);
                    }
                    else
                    {
                        tryCounter--;
                        MessageBox.Show("Try again.   \n" + tryCounter + " attempts left  ", "Not guessed", MessageBoxButton.OK);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Field must not be empty. Enter integer number.", "Empty field", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (NumberExeption)
            {
                MessageBox.Show("Field must be in a special range(from "+ generator.minValue +" to " + generator.maxValue+")", "Empty field", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
