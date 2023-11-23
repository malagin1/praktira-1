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
using static System.Math;

namespace zzz4
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(NumberC.Text, out int c))
            {
                MessageBox.Show("Введите число");
            }
            if (!int.TryParse(NumberX.Text, out int x))
            {
                MessageBox.Show("Введите число");
            }
            if (!int.TryParse(NumberA.Text, out int a))
            {
                MessageBox.Show("Введите число");
            }
            if (!int.TryParse(NumberW.Text, out int w))
            {
                MessageBox.Show("Введите число");
            }
            if (!int.TryParse(NumberT.Text, out int t))
            {
                MessageBox.Show("Введите число");
            }
            double y, g;
            g = c + 24.8;
            y = (Pow(Pow(x, 5), 3) * Sqrt(a * x + Sqrt(Abs(a + x)))) / (4 * Pow(Cos(a * x), 2));
            Resul.Text = $"{a}{x}{c}";
        }
    }
}
