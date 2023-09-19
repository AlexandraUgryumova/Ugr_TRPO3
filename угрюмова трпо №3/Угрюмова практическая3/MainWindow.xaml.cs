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

namespace Угрюмова_практическая3
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

        private void rezault_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(first_txt.Text);
                double b = double.Parse(second_txt.Text);
                double c = 0;
                switch (combobox1.SelectedIndex)
                {
                    case 0:
                        c = a + b;
                        break;
                    case 1:
                        c = a - b;
                        break;
                    case 2:
                        c = a * b;
                        break;
                    case 3:
                        c = a / b;
                        break;
                    default:
                        MessageBox.Show("операция не выбрана");
                        break;
                }
                rezault_label.Content = c.ToString();
            }
            catch
            {
                MessageBox.Show("данные введены не корректно");
            }
        }
    }
}
