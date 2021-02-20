using Chat.PiperChat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
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


namespace Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, PiperChat.IMessageServiceCallback
    {

        Dictionary<int, List<Message>> chatList;
        Dictionary<int, int> currentMessageCount;
        InstanceContext instanceContext;
        MessageServiceClient client;
        User currentSelected;

        public MainWindow()
        {
            instanceContext = new InstanceContext(this);
            client = new MessageServiceClient(instanceContext);
            chatList = new Dictionary<int, List<Message>>();
            currentMessageCount = new Dictionary<int, int>();


            client.Connect(Global.CurrentLoggedInUser);
            InitializeComponent();
            MessagePanel.Children.Clear();
            
            TAbout.Text = Global.CurrentLoggedInUser.About;
            TLocation.Text = Global.CurrentLoggedInUser.Location;
            TContact.Text = Global.CurrentLoggedInUser.ContactNo;
            TUserName.Text = Global.CurrentLoggedInUser.Name;
            TEmail.Text = Global.CurrentLoggedInUser.Email;
            TCurrentChatName.Text = "PiperChat";
 
        }

   

        private void EstablishConnection(object sender, RoutedEventArgs e)
        {
         
        }

        void incrementMessageCount(int id)
        {
            if (currentMessageCount.ContainsKey(id))
            {
                int count = currentMessageCount[id];
                count++;
                currentMessageCount[id] = count;
            }
            else
            {
                currentMessageCount.Add(id, 1);
            }
            
        }

     

        public void ForwardToClient(Message message)
        {
            if (chatList.ContainsKey(message.SenderId))
            {
                List<Message> messageList = chatList[message.SenderId];
                messageList.Add(message);
                chatList[message.SenderId] = messageList;

            }
            else
            {
               List<Message> messageList = new List<Message>();
               messageList.Add(message);
               chatList.Add(message.SenderId, messageList);
            }
            incrementMessageCount(message.SenderId);

            if (currentSelected!=null && message.SenderId == currentSelected.UserId)
            {
                RenderMessageGrid(message.SenderId);
            }

            //MessagePanel.Children.Add(new UserControlMessageReceived(message));
        }

        public void UsersConnected(User[] users)
        {
            List<User> userList = users.Where(user => user.UserId != Global.CurrentLoggedInUser.UserId).ToList<User>();
            ActiveUserList.ItemsSource = userList;
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            Message message = new Message();
            message.MessageSent = TxtMessage.Text;
            message.SenderId = Global.CurrentLoggedInUser.UserId;
            message.ReceiverId =  ((User)(ActiveUserList.SelectedItem)).UserId;
            message.TimeSent = DateTime.Now;
            client.SendMessage(message);

            if (chatList.ContainsKey(message.ReceiverId))
            {
                List<Message> messageList = chatList[message.ReceiverId];
                messageList.Add(message);
                chatList[message.ReceiverId] = messageList;
            }
            else
            {
                List<Message> messageList = new List<Message>();
                messageList.Add(message);
                chatList.Add(message.ReceiverId, messageList);
            }
           
            RenderMessageGrid(message.ReceiverId);
            //MessagePanel.Children.Add(new UserControlMessageSent(message));
            TxtMessage.Text = "";
        }

        void RenderMessageGrid(int id)
        {
            MessagePanel.Children.Clear();
            List<Message> messageOfUser = chatList.First(kvp => kvp.Key == id).Value;
            foreach(Message message in messageOfUser)
            {
                if (message.SenderId == Global.CurrentLoggedInUser.UserId)
                {
                    MessagePanel.Children.Add(new UserControlMessageSent(message));
                }
                else
                {
                    MessagePanel.Children.Add(new UserControlMessageReceived(message));
                }
            }
        }

        private void ActiveUserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)ActiveUserList.SelectedItem;
            if (user != null)
            {
                currentSelected = user;
                TCurrentChatName.Text = user.Name;
                TAbout.Text = user.About;
                TLocation.Text = user.Location;
                TContact.Text = user.ContactNo;
                TUserName.Text = user.Name;
                TEmail.Text = user.Email;

                currentMessageCount[user.UserId] = 0;
            
            }
            if (user != null && chatList.ContainsKey(user.UserId))
            {
                RenderMessageGrid(user.UserId);
            }
            else
            {
                MessagePanel.Children.Clear();
            }
            
        }

     
    }


}
