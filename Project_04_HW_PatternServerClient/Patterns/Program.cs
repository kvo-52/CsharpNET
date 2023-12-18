using System.Net.Sockets;
using System.Net;

namespace PatternsServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Start();
        }

    }
}