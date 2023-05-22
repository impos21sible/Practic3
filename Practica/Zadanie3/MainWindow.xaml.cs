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

namespace Zadanie3
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
    if (int.TryParse(textBoxA.Text, out int a) &&
        int.TryParse(textBoxB.Text, out int b) &&
        int.TryParse(textBoxC.Text, out int c))
    {
                int sum = 0;

        if (b <= c && b <= a)
        {
            sum = a + c;
        }
        else if (a <= c && a <= b)
        {
            sum = b + c;
        }
        else if (c<=a && c<=b)
        {
            sum = a + b;
        }

        ResultLabel.Content = $"Сумма двух наибольших чисел: {sum }" ;
    }
    else
    {
        ResultLabel.Content = "Ошибка ввода чисел.";
    }
}


    }
}

