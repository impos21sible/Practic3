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

namespace Zadanie2
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
            if(int.TryParse(textBoxA.Text, out int a) && int.TryParse(textBoxB.Text, out int b)&& int.TryParse(textBoxC.Text, out int c))
              {
                int Poloshitcount = 0;
                int Otricatelniycount = 0;
                if (a>0)
                {
                    Poloshitcount++;
                }
                else if (a <0)
                {
                    Otricatelniycount++;
                }

                if (b > 0)
                {
                    Poloshitcount++;
                }
                else if (b < 0)
                {
                    Otricatelniycount++;
                }

                if (c > 0)
                {
                    Poloshitcount++;
                }
                else if (c < 0)
                {
                    Otricatelniycount++;
                }

                ResultLabel.Content = $"Количество полож чисел:{Poloshitcount}\nКоличество отриц чисел{Otricatelniycount}";


            }
            else
            {
                ResultLabel.Content = "Ошибка вывода";
            }


        }
            
    }
}
