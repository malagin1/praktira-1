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

namespace zzzz2
{
   
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

            if (!double.TryParse(textbox3.Text, out double c))
            { MessageBox.Show("Поле только для чисел"); }


            {

                int A = 1;
                int B = 2;
                int C = 3;


                int temp = A;
                A = B;
                B = C;
                C = temp;


                answer.Text += ($"A: {A}, B: {B}, C: {C}");
            }
        }
    }
}
