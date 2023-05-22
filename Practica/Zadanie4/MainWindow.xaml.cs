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

namespace Zadanie4
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBoxA.Text, out double a) &&
                double.TryParse(textBoxB.Text, out double b) &&
                double.TryParse(textBoxC.Text, out double x))
            {
                double result;

                if (x > Math.PI)
                {
                    result = 1 - Math.Exp(-a * x) * Math.Sin(a * x + b);
                }
                else if (x >= -Math.PI && x <= Math.PI)
                {
                    result = 1 - Math.Exp(-a * x) * (a * x + b);
                }
                else
                {
                    result = 1 - (Math.Exp(-a * x) + Math.Exp(-b * x));
                }

                ResultLabel.Content  = $"Значение функции:{result:f2} ";
            }
            else
            {
                ResultLabel.Content = "Ошибка ввода чисел.";
            }
        }



    }
}
