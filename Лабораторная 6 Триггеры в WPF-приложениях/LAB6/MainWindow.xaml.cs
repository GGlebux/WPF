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

namespace LAB6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnOpen.Click += BtnOpen_Click;
            btnClear.Click += BtnClear_Click;
            btnClose.Click += BtnClose_Click;
            cmbFontStyle.SelectionChanged += CmbFontStyle_SelectionChanged;

            txtBox1.TextChanged += TxtBox_TextChanged;
            txtBox2.TextChanged += TxtBox_TextChanged;
        }
        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            // Implement Open button functionality here
        }
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            // Check if both text boxes are empty before closing
            if (string.IsNullOrWhiteSpace(txtBox1.Text) && string.IsNullOrWhiteSpace(txtBox2.Text))
            {
                Close();
            }
        }
        private void TxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnClose.IsEnabled = (string.IsNullOrWhiteSpace(txtBox1.Text) && string.IsNullOrWhiteSpace(txtBox2.Text));
        }
        private void CmbFontStyle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedFont = ((ComboBoxItem)cmbFontStyle.SelectedItem).Content.ToString();
            txtBox1.FontFamily = new FontFamily(selectedFont);
            txtBox2.FontFamily = new FontFamily(selectedFont);
        }
    }
}
