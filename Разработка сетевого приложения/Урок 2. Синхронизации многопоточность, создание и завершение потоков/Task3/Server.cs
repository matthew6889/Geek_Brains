﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Server
    {
        private static bool exitRequested = false;

        public static void AcceptMsg()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
            UdpClient udpClient = new UdpClient(16874);
            Console.WriteLine("Сервер ожидает сообщение");

            Task exitTask = Task.Run(() =>
            {
                Console.ReadKey();
                exitRequested = true;
            });

            while (!exitRequested)
            {

                byte[] buffer = udpClient.Receive(ref ep);
                string data = Encoding.UTF8.GetString(buffer);
                Task.Run(() =>
                {
                    Message msg = Message.fromJson(data);
                    Console.WriteLine(msg.ToString());
                    Message responseMsg = new Message("Server", "Message accept on serv!");
                    string responseMsgJs = responseMsg.toJson();
                    byte[] responseDate = Encoding.UTF8.GetBytes(responseMsgJs);
                    udpClient.Send(responseDate, ep);
                });
                exitTask.Wait();
            }
        }
    }
}
