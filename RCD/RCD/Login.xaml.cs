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
using System.Windows.Shapes;

namespace RCD
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private Userss _currentUser = new Userss();
        public Login()
        {
            DataContext = _currentUser;
            InitializeComponent();
        }

        private void btnLog_click(object sender, RoutedEventArgs e)
        {

                bool successLogin = Logining(LoginTb.Text.Trim(), PasswordTb.Text.Trim());
                MessageBox.Show(successLogin ? "Вы вошли в систему" : "Зарегистрируйтесь, Вас не существует");
                if (successLogin == true)
                {
                    Home home = new Home(Log(LoginTb.Text.Trim(), PasswordTb.Text.Trim()).Id_user);
                    home.Show();
                    Close();
                }
            
        }
        public static bool Logining(string email, string pass)
        {
         return REntities.GetContext().Usersses.Any(p => p.Login == email && p.Password == pass);
        }
        public Userss Log(string email, string pass)
        {
            return REntities.GetContext().Usersses.FirstOrDefault(p => p.Login == email && p.Password == pass);
        }

    }
}
