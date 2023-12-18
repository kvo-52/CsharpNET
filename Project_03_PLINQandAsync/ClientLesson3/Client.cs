using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientLesson3
{
    internal class Client
    {
        public static async Task SendMessageAsync()
        {
            UdpClient udpClient = new UdpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 45512);

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("От кого:");
                string? from = Console.ReadLine();
                string? message;
                do
                {
                    Console.WriteLine("Введите сообщение:");
                    message = Console.ReadLine();
                    Console.Clear();

                } while (string.IsNullOrEmpty(message));

                Message msg = new Message() { Text = message, NickNameFrom = from, NickNameTo = "Server", DateTime = DateTime.Now };
                var JSONmsg = msg.SerializeMessageToJson();
                byte[] buffer = Encoding.UTF8.GetBytes(JSONmsg);
                int bytes = await udpClient.SendAsync(buffer, buffer.Length, iPEndPoint);
                Console.WriteLine($"Отправлено {bytes} байт");

                if (message.ToLower().Equals("exit")) flag = false;

                byte[] recieiveBuf = udpClient.Receive(ref iPEndPoint);
                Console.WriteLine($"Получено {recieiveBuf.Length} байт");
            }
        }
    }
}
