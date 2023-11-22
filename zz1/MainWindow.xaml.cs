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

namespace zz1
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
            if (!double.TryParse(textbox1.Text, out double a))
            { MessageBox.Show("Поле только для чисел"); }

            if (!double.TryParse(textbox2.Text, out double b))
            { MessageBox.Show("Поле только для чисел"); }
            double f;
            f = (a + b) / 2;

            answer.Text += " равно  " + f + "\n";
        }
    }
}
