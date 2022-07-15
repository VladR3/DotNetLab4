using System.ServiceModel;

namespace ChatLibrary
{
    [ServiceContract(CallbackContract = typeof(IChatServiceCallback))]
    public interface IChatService
    {
        [OperationContract]
        int Connect(string username);

        [OperationContract(IsOneWay = true)]
        void Disconnect(int id);

        [OperationContract(IsOneWay = true)]
        void SendMessage(ModelMessage chatMessage);
        
        [OperationContract(IsOneWay = true)]
        void SendUsers();
    }
}
