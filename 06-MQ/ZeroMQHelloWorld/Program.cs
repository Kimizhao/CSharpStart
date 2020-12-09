using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ZeroMQHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Title = "NetMQ HelloWorld";

            using (var server = new ResponseSocket("@tcp://localhost:5556"))
            using (var client = new RequestSocket("tcp://localhost:5556"))
            {
                client.SendFrame("Hello");

                Console.WriteLine("From Client: {0}", server.ReceiveFrameString());

                server.SendFrame("Hi Back");

                Console.WriteLine("From Server: {0}", client.ReceiveFrameString());

                Console.WriteLine();
                Console.Write("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
