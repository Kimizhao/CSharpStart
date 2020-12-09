using NetMQ;
using NetMQ.Sockets;
using System;
using System.Threading;

namespace ZeroMQPublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ZeroMQPublisher";

            using (var publisher = new PublisherSocket())
            {
                publisher.Bind("tcp://*:5556");

                int i = 0;

                while (true)
                {
                    publisher
                        .SendMoreFrame("A") // Topic
                        .SendFrame(i.ToString()); // Message

                    i++;
                    Thread.Sleep(1000);
                }
            }

        }
    }
}
