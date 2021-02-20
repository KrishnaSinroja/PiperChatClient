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
using System.Windows.Navigation;
using WpfApp1.PiperChatClient;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public object NevigationService { get; private set; }

        public Window1()
        {
            InitializeComponent();
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            string name = TName.Text;
            string email = TEmail.Text;
            string password = TPassword.Text;

            PiperChatClient.User user = new PiperChatClient.User();
            user.Name = name;
            user.Email = email;
            user.Password = password;

            UserServiceClient client = new UserServiceClient();
            string response = client.InsertUserRecord(user);
            Console.WriteLine(response);

            var window = new Window2();
            window.Show();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            var window = new Window2();
            window.ShowDialog();
        }
    }
}
