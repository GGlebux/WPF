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

namespace лабораторная_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LinearGradientBrush backgroundBrush = new LinearGradientBrush();
            backgroundBrush.StartPoint = new Point(0, 0);
            backgroundBrush.EndPoint = new Point(1, 1);
            backgroundBrush.GradientStops.Add(new GradientStop(Colors.LightGray, 0));
            backgroundBrush.GradientStops.Add(new GradientStop(Colors.White, 1));
            this.Background = backgroundBrush;

            Style largeTextBoxStyle = (Style)Resources["LargeTextBoxStyle"];
            largeTextBox.Style = largeTextBoxStyle;

            Style smallTextBoxStyle = (Style)Resources["SmallTextBoxStyle"];
            smallTextBox1.Style = smallTextBoxStyle;
            smallTextBox2.Style = smallTextBoxStyle;
            smallTextBox3.Style = smallTextBoxStyle;
            smallTextBox4.Style = smallTextBoxStyle;
        }
    }
}
