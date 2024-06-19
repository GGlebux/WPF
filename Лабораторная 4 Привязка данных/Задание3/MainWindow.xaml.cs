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

namespace Задание_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Привязка значения ползунка к размеру шрифта текстового блока
            Binding bindingFontSize = new Binding("Value");
            bindingFontSize.Source = sliderFontSize;
            bindingFontSize.Path = new PropertyPath("Value");
            bindingFontSize.Mode = BindingMode.TwoWay;
            bindingFontSize.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            txtBlock.SetBinding(TextBlock.FontSizeProperty, bindingFontSize);

            // Привязка свойства Text текстового блока к свойству Value ползунка
            Binding bindingText = new Binding("Value");
            bindingText.Source = sliderFontSize;
            bindingText.Path = new PropertyPath("Value");
            bindingText.Mode = BindingMode.OneWay;
            bindingText.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            txtBlock.SetBinding(TextBlock.TextProperty, bindingText);
            txtBlock.Text = "Изменение размера шрифта";


        }

        private void SliderFontSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

    }
}
