using System.ServiceModel;

namespace ChatLibrary
{
    public class SystemUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OperationContext Context { get; set; }
    }
}
