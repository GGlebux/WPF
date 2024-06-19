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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PointAnimation gradientAnimation = new PointAnimation
            {
                From = new Point(0.3, 0.3),
                To = new Point(0.7, 0.7),
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = false, // Изменено на false
                RepeatBehavior = RepeatBehavior.Forever
            };
            Storyboard.SetTargetName(gradientAnimation, "radialGradientBrush");
            Storyboard.SetTargetProperty(gradientAnimation, new PropertyPath(RadialGradientBrush.GradientOriginProperty));

            // Создание анимации для Direction тени
            DoubleAnimation shadowDirectionAnimation = new DoubleAnimation
            {
                From = 0,
                To = 360,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = false, // Изменено на false
                RepeatBehavior = RepeatBehavior.Forever
            };
            Storyboard.SetTargetName(shadowDirectionAnimation, "shadowEffect");
            Storyboard.SetTargetProperty(shadowDirectionAnimation, new PropertyPath(DropShadowEffect.DirectionProperty));

            // Создание Storyboard и добавление анимаций
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(gradientAnimation);
            storyboard.Children.Add(shadowDirectionAnimation);

            // Начало анимации
            storyboard.Begin(this);
        }
    
    }
}
