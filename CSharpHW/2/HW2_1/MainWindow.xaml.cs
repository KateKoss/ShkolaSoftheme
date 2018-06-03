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

namespace HW2_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void typeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ListBoxItem)typeListBox.SelectedItem;
            switch (selectedItem.Content.ToString())
            {
                case "byte":
                    maxValueLabel.Content = byte.MaxValue.ToString();
                    minValueLabel.Content = byte.MinValue.ToString();
                    break;
                case "sbyte":
                    maxValueLabel.Content = sbyte.MaxValue.ToString();
                    minValueLabel.Content = sbyte.MinValue.ToString();
                    break;
                case "short":
                    maxValueLabel.Content = short.MaxValue.ToString();
                    minValueLabel.Content = short.MinValue.ToString();
                    break;
                case "ushort":
                    maxValueLabel.Content = ushort.MaxValue.ToString();
                    minValueLabel.Content = ushort.MinValue.ToString();
                    break;
                case "int":
                    maxValueLabel.Content = int.MaxValue.ToString();
                    minValueLabel.Content = int.MinValue.ToString();
                    break;
                case "uint":
                    maxValueLabel.Content = uint.MaxValue.ToString();
                    minValueLabel.Content = uint.MinValue.ToString();
                    break;
                case "long":
                    maxValueLabel.Content = long.MaxValue.ToString();
                    minValueLabel.Content = long.MinValue.ToString();
                    break;
                case "ulong":
                    maxValueLabel.Content = ulong.MaxValue.ToString();
                    minValueLabel.Content = ulong.MinValue.ToString();
                    break;
                case "float":
                    maxValueLabel.Content = float.MaxValue.ToString();
                    minValueLabel.Content = float.MinValue.ToString();
                    break;
                case "double":
                    maxValueLabel.Content = double.MaxValue.ToString();
                    minValueLabel.Content = double.MinValue.ToString();
                    break;
                case "decimal":
                    maxValueLabel.Content = decimal.MaxValue.ToString();
                    minValueLabel.Content = decimal.MinValue.ToString();
                    break;
                default:
                    maxValueLabel.Content = "Error";
                    minValueLabel.Content = "Error";
                    break;
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
