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

namespace WpfApp1
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
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            // Add code to open a file or do something else
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedValue = (comboBox.SelectedItem as ComboBoxItem).Content.ToString();

            switch (selectedValue)
            {
                case "Bold":
                    textBox1.FontWeight = FontWeights.Bold;
                    textBox2.FontWeight = FontWeights.Bold;
                    break;
                case "Italic":
                    textBox1.FontStyle = FontStyles.Italic;
                    textBox2.FontStyle = FontStyles.Italic;
                    break;
                case "Underline":
                    textBox1.TextDecorations = TextDecorations.Underline;
                    textBox2.TextDecorations = TextDecorations.Underline;
                    break;
                default:
                    textBox1.FontWeight = FontWeights.Normal;
                    textBox2.FontWeight = FontWeights.Normal;
                    textBox1.FontStyle = FontStyles.Normal;
                    textBox2.FontStyle = FontStyles.Normal;
                    textBox1.TextDecorations = null;
                    textBox2.TextDecorations = null;
                    break;
            }
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = Brushes.LightGray;
        }

        private void Button_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Background = Brushes.Transparent;
        }
    }
}
