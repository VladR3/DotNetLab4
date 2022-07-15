using ChatLibrary;
using System;
using System.ServiceModel;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ChatService)))
            {
                host.Open();
                Console.WriteLine("Server is started!");
                Console.ReadLine();
            }
        }
    }
}
