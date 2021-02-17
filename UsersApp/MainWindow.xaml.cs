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

namespace RegisterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string Login = TextBoxLogin.Text;
            string Password = TextBoxPassword.Password;
            string Password_Rep = TextBoxPassword_Rep.Password;
            string Email = TextBoxEmail.Text.ToLower();

            if(Login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Это поле введено не корректно!";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            else if (Password.Length < 6)
            {
                TextBoxPassword.ToolTip = "Пароль не может быть меньше 6-ти символов!";
                TextBoxPassword.Background = Brushes.DarkRed;
            }
            else if (Password != Password_Rep)
            {
                TextBoxPassword_Rep.ToolTip = "Пароли не совпадают!";
                TextBoxPassword_Rep.Background = Brushes.DarkRed;
            }
            else if (Email.Length < 5 || !Email.Contains("@") || !Email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Это поле введено не корректно!";
                TextBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxPassword.Background = Brushes.Transparent;
                TextBoxPassword_Rep.Background = Brushes.Transparent;
                TextBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Успешно!");
            }
        }
    }
}
