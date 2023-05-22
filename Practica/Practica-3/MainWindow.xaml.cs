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

namespace Practica_3
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
            if (int.TryParse(textBoxA.Text, out int a))
            {
                if (a >= 10 && a <= 99 ) // Проверка что числа двухзначные
                {
                    int PervoeChislo = a / 10; //  перваая цифра числа "a"
                    int VtoroeChislo = a % 10; //  вторую цифру числа "a"

                    if (PervoeChislo == VtoroeChislo)
                    {
                        MessageBox.Show("Цифры числа одинаковы");
                    }
                    else
                    {
                        MessageBox.Show("Цифры числа различны");
                    }
                }
                else
                {
                    MessageBox.Show("Введите двухзначные числа");
                }
            }
            else
            {
                MessageBox.Show("Введите корректные числа");
            }
        }








    }
}
