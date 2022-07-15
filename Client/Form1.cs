using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form, IChatServiceCallback
    {
        private ChatServiceClient Client;
        private static int UserId;
        private List<ChatLibrary.ModelMessage> messages = new List<ChatLibrary.ModelMessage>();

        public Form1(string username)
        {
            InitializeComponent();
            Client = new ChatServiceClient(new System.ServiceModel.InstanceContext(this));
            UserId = Client.Connect(username);
            Client.SendUsers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxMessage.Items.Clear();
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            var selectedUser = listBoxUsers.SelectedItem as ChatLibrary.ModelUser;
            var chatMessage = new ChatLibrary.ModelMessage
            {
                Text = textBoxMessage.Text,
                Sender = new ChatLibrary.ModelUser
                {
                    Id = UserId,
                },
                Receiver = new ChatLibrary.ModelUser 
                { 
                    Id = selectedUser == null ? 0 : selectedUser.Id,
                }
            };
            Client.SendMessage(chatMessage);
            textBoxMessage.Text = String.Empty;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Client.Disconnect(UserId);
            Client.SendUsers();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderMessages();
        }

        public void SendMessageToClient(ChatLibrary.ModelMessage chatMessage)
        {
            messages.Add(chatMessage);
            RenderMessages();
        }

        public void SendUsersToClient(ChatLibrary.ModelUser[] users)
        {
            var usersWithoutMe = users.ToList();
            usersWithoutMe.Insert(0, new ChatLibrary.ModelUser { Name = "- All -" });
            usersWithoutMe = usersWithoutMe.Where(u => u.Id != UserId).ToList();
            listBoxUsers.Items.Clear();
            listBoxUsers.Items.AddRange(usersWithoutMe.ToArray());
        }

        public void RenderMessages()
        {
            var selectedUser = listBoxUsers.SelectedItem as ChatLibrary.ModelUser;
            var selectedUserId = selectedUser == null ? 0 : selectedUser.Id;

            IEnumerable<ChatLibrary.ModelMessage> showMessages;
            if(selectedUserId == 0) 
                showMessages = messages.Where(m => m.Receiver.Id == 0);
            else
                showMessages = messages.Where(m => (m.Sender.Id == selectedUserId && m.Receiver.Id == UserId) || (m.Sender.Id == UserId && m.Receiver.Id == selectedUserId));
           
            listBoxMessage.Items.Clear();
            listBoxMessage.Items.AddRange(showMessages.ToArray());
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Client.Disconnect(UserId);
            Client.SendUsers();
            Close();
        }
    }
}
