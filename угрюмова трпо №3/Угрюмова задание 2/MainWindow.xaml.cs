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

namespace Угрюмова_задание_2
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

        private void combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(combobox1.SelectedIndex)
            {
                case 0:
                    registration_lbl.Content = "Регистрация";
                    name_lbl.Content = "Имя:";
                    female_lbl.Content = "Фамилия:";
                    email_lbl.Content = "Электронная почта";
                    phone_lbl.Content = "Номер телефона";
                    break;
                case 1:
                    registration_lbl.Content = "Registration";
                    name_lbl.Content = "Name:";
                    female_lbl.Content = "Female:";
                    email_lbl.Content = "E-mail";
                    phone_lbl.Content = "Nomber phone";
                    break;
                case 2:
                    registration_lbl.Content = " Inscription";
                    name_lbl.Content = "Nom:";
                    female_lbl.Content = "Femelle:";
                    email_lbl.Content = "E-mail";
                    phone_lbl.Content = "Numéro de téléphone";
                    break;
                default:
                    break;
            }
        }
    }
}
