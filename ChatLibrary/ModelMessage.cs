namespace ChatLibrary
{
    public class ModelMessage
    {
        public string Text { get; set; }
        public ModelUser Sender { get; set; }
        public ModelUser Receiver { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
