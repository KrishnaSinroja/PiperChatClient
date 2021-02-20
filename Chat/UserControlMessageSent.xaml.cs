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

namespace Chat
{
    /// <summary>
    /// Interaction logic for UserControlMessageSent.xaml
    /// </summary>
    public partial class UserControlMessageSent : UserControl
    {
        private PiperChat.Message messageReceived;

        public UserControlMessageSent()
        {
            InitializeComponent();
        }

        public UserControlMessageSent(PiperChat.Message message)
        {
            this.messageReceived = message;
            InitializeComponent();
            Message.Text = message.MessageSent;
            Time.Text = message.TimeSent.ToShortTimeString();
        }
    }
}
