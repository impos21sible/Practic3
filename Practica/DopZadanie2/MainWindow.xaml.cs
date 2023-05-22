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

namespace DopZadanie2
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
            if (int.TryParse(textBoxA.Text, out int number))
            {
                string Opisanie;

                if (number >= 1 && number <= 9)
                {
                    Opisanie = "однозначное число";
                }
                else if (number >= 10 && number <= 99)
                {
                    if (number % 2 == 0)
                    {
                        Opisanie = "четное двузначное число";
                    }
                    else
                    {
                        Opisanie = "нечетное двузначное число";
                    }
                }
                else if (number >= 100 && number <= 999)
                {
                    if (number % 2 == 0)
                    {
                        Opisanie = "четное трехзначное число";
                    }
                    else
                    {
                        Opisanie = "нечетное трехзначное число";
                    }
                }
                else
                {
                    Opisanie = "число не входит в диапазон от 1 до 999";
                }

                MessageBox.Show(Opisanie);
            }
            else
            {
                MessageBox.Show("Введено некорректное число");
            }
        }


    }
}
