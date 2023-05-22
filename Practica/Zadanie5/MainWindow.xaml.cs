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

namespace Zadanie5
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
            try
            {
                if (int.TryParse(textBoxA.Text, out int x) &&
                    int.TryParse(textBoxB.Text, out int y))
                {
                    if (x < 12 && y == x)
                    {
                        ResultLabel.Content = "На пересечении";
                    }
                    else if (y < x && (x * x + y * y) < 144)
                    {
                        ResultLabel.Content = "Попала в область";
                    }
                    else
                    {
                        ResultLabel.Content = "Точка не попала в область";
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
