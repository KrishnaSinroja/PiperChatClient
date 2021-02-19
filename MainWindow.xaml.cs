using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using WpfApp1.PiperChat;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, PiperChat.IMessageServiceCallback
    {
        InstanceContext instanceContext;
        MessageServiceClient client;
        public MainWindow()
        {
            instanceContext = new InstanceContext(this);
            client = new MessageServiceClient(instanceContext); 
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Message message = new Message();
            message.MessageSent = Message.Text;
            message.SenderId = int.Parse(Sender.Text);
            message.ReceiverId = int.Parse(Receiver.Text);
            message.TimeSent = DateTime.Now;

            client.SendMessage(message);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            MessageServiceClient client = new MessageServiceClient(instanceContext);
            User user = new User();
            user.UserId = int.Parse(Sender.Text);
            user.Username = Username.Text;

            client.Connect(user);
        }


        public void ForwardToClient(Message message)
        {
            MessageBox.Items.Add(message.MessageSent);
        }

        public void UsersConnected(User[] users)
        {
            foreach(User user in users)
            {
                ActiveUsers.Items.Add(user.Username);
            }
           
        }
    }
}
