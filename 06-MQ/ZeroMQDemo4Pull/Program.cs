using NetMQ;
using NetMQ.Sockets;
using System;

namespace ZeroMQDemo4Pull
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ZeroMQDemo4Pull";
            using (var pullSocket = new PullSocket())
            {
                pullSocket.Connect("tcp://127.0.0.1:5556");

                while (true)
                {
                    var topic = pullSocket.ReceiveFrameString();
                    var msg = pullSocket.ReceiveFrameString();
                    var data = pullSocket.ReceiveFrameBytes();
                    Console.WriteLine("From Pull: {0} {1} {2}", topic, msg, data[0]);
                    //Console.WriteLine("From Pull: {0}", msg);
                }
            }
        }
    }
}
