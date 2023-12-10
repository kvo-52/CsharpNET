using System.Net.Sockets;
using System.Net;
using System.Text;


namespace HW01_ClientUDP
{
    public class UDPClient
    {
        public static void SendMessage(string from, int i, string ip = "127.0.0.1")
        {

            UdpClient udpClient = new UdpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), 12345);

            string messageText = "Привет " + i;

            Message message = new() { Text = messageText, DateTime = DateTime.Now, NickNameFrom = from, NickNameTo = "Server" };
            string json = message.SerializeMessageToJson();

            var data = Encoding.UTF8.GetBytes(json);
            udpClient.Send(data, data.Length, iPEndPoint);
            Console.WriteLine($"Отправлено {data.Length}");

            byte[] buffer = udpClient.Receive(ref iPEndPoint);
            var answer = Encoding.UTF8.GetString(buffer);

            Console.WriteLine(answer);


        }
    }
}
