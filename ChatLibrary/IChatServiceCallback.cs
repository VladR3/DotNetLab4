using System.Collections.Generic;
using System.ServiceModel;

namespace ChatLibrary
{
    [ServiceContract]
    public interface IChatServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendMessageToClient(ModelMessage chatMessage);

        [OperationContract(IsOneWay = true)]
        void SendUsersToClient(IEnumerable<ModelUser> users);
    }
}
