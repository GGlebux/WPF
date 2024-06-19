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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab8._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ScaleTransform scaleTransform = new ScaleTransform();
        private object textBox1;

        public MainWindow()
        {
            InitializeComponent();
            // Привязка свойства ScaleX и ScaleY преобразования scaleTransform к значению Slider
            scaleSlider.ValueChanged += OnScaleSliderValueChanged;

            // Начальное применение преобразования scaleTransform к StackPanel с элементами управления
            rootElement.LayoutTransform = scaleTransform;
        }
        private void OnScaleSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Обновление значений ScaleX и ScaleY преобразования scaleTransform
            scaleTransform.ScaleX = scaleSlider.Value;
            scaleTransform.ScaleY = scaleSlider.Value;
        }
    }
}
