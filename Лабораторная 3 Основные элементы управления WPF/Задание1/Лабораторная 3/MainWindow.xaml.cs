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

namespace Лабораторная_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object statusTextBlock;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void ChangeBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            byte R = (byte)rnd.Next(0, 256);
            byte G = (byte)rnd.Next(0, 256);
            byte B = (byte)rnd.Next(0, 256);
            Color color = Color.FromRgb(R, G, B);
            Background = new SolidColorBrush(color);
            UpdateStatusBar("Background color changed");
        }

        private void AboutDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Developed by Your Name", "About Developer", MessageBoxButton.OK, MessageBoxImage.Information);
            UpdateStatusBar("Information about the developer");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void UpdateStatusBar(string status)
        {
            StatusBarTextBlock.Text = status;
        }

        private void MenuItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            UpdateStatusBar(menuItem.Header.ToString());
        }

        private void MenuItem_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            UpdateStatusBar("Ready");
        }

        private void ToolBarButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button button = (Button)sender;
            UpdateStatusBar(button.ToolTip.ToString());
        }

        private void ToolBarButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            UpdateStatusBar("Ready");
        }
    }

}
