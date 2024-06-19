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

namespace Лаб._7_з._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object colorAnimation;

        public MainWindow()
        {
            InitializeComponent();

            AnimatePulsar();
        }
        private void AnimatePulsar()
        {
            RadialGradientBrush gradientBrush = pulseEllipse.Fill as RadialGradientBrush;
            if (gradientBrush != null)
            {
                ColorAnimation colorAnimation = new ColorAnimation
                {
                    From = Colors.Blue,
                    To = Colors.White,
                    Duration = TimeSpan.FromSeconds(1),
                    AutoReverse = true,
                    RepeatBehavior = RepeatBehavior.Forever
                };

                gradientBrush.GradientStops[1].BeginAnimation(GradientStop.ColorProperty, colorAnimation);
            }
        }
    }
}
