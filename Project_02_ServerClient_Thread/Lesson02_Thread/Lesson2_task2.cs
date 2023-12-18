using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Lesson02_Thread
{
    internal class Lesson2_task2
    {
        static async Task3(string[] args)
        {
            const string sait = "yandex.ru";

            IPAddress[] iPAddress = Dns.GetHostAddresses(sait, System.Net.Sockets.AddressFamily.InterNetwork);

            Dictionary<IPAddress, long> pings = new();

            {
                foreach (var item in iPAddress)
                {
                    Thread tr = new Thread(() =>
                    {
                        Ping ping = new Ping();
                        PingReply pr = ping.Send(item);
                        pings.Add(item, pr.RoundtripTime);
                        Console.WriteLine($"{item} {pr.RoundtripTime}");

                    });
                    tr.Start();
                    tr.Join();
                }

                var minPing = pings.Min(x => x.Value);
                Console.WriteLine();
                Console.WriteLine(minPing);
            }
        }



    }
}
