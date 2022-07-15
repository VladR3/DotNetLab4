using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace ChatLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChatService
    {
        List<SystemUser> users = new List<SystemUser>();
        int nextUserId = 1;
        public int Connect(string username)
        {
            SystemUser user = new SystemUser()
            {
                Id = nextUserId++,
                Name = username,
                Context = OperationContext.Current,
            };
            users.Add(user);
            return user.Id;
        }

        public void Disconnect(int id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            if (user != null)
                users.Remove(user);
        }

        public void SendMessage(ModelMessage chatMessage)
        {
            foreach (SystemUser user in users)
            {
                user.Context.GetCallbackChannel<IChatServiceCallback>().SendMessageToClient(chatMessage);
            }
        }

        public void SendUsers()
        {
            var sendUsers = users.Select(u => new ModelUser { Id = u.Id, Name = u.Name });
            foreach (var user1 in users)
            {
                user1.Context.GetCallbackChannel<IChatServiceCallback>().SendUsersToClient(sendUsers);
            }
        }
    }
}