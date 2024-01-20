using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Task2
{
    /*Напишите многопоточное приложение, которое определяет все IP-адреса интернет-ресурса и определяет до которого из них лучше Ping.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            string resources = "yandex.ru";

            var IpAdresses = Dns.GetHostAddresses(resources, AddressFamily.InterNetwork);

            foreach (var adress in IpAdresses)
            {
                Console.WriteLine(adress);
            }

            Dictionary<IPAddress, long> pings = new Dictionary<IPAddress, long>();

            List<Thread> threads = new List<Thread>();
            foreach (var address in IpAdresses)
            {
                var tr = new Thread(() =>
                {
                    Ping ping = new Ping();
                    PingReply pingReply = ping.Send(address);

                    pings.Add(address, pingReply.RoundtripTime);
                });
                threads.Add(tr);
                tr.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            long min = long.MaxValue;

            foreach (var ping in pings)
            {
                if (ping.Value < min)
                {
                    min = ping.Value;
                }
                Console.WriteLine(String.Format($"{ping.Key} - {ping.Value} ms"));
            }

        }
    }
}