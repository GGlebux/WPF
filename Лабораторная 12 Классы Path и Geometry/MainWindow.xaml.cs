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
using System.Windows.Media.Animation;
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
        private void RoadSign_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var roadSign = button.Content as string;

            // Implement resizing and moving animation here
            DoubleAnimation sizeX = new DoubleAnimation
            {
                To = 200,
                Duration = TimeSpan.FromSeconds(1)
            };

            DoubleAnimation sizeY = new DoubleAnimation
            {
                To = 200,
                Duration = TimeSpan.FromSeconds(1)
            };

            path1.BeginAnimation(Path.WidthProperty, sizeX);
            path1.BeginAnimation(Path.HeightProperty, sizeY);
        }

        private void Path_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var path = sender as Path;

            ColorAnimation colorAnimation = new ColorAnimation
            {
                Duration = TimeSpan.FromSeconds(1),
                To = Colors.Yellow
            };

            SolidColorBrush brush = new SolidColorBrush();
            brush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
            path.Fill = brush;
        }

        private void Path_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var path = sender as Path;
            path.Fill = new SolidColorBrush(Colors.Blue); // Reset the color back to default
        }
    }
}
