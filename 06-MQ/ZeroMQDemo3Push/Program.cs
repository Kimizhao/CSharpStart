using NetMQ;
using NetMQ.Sockets;
using System;
using System.Threading;

namespace ZeroMQDemo3Push
{
    /// <summary>
    /// 参考：
    /// 1.https://github.com/zeromq/netmq/blob/master/src/NetMQ.Tests/PushPullTests.cs
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ZeroMQDemo3Push";

            using (var pushSocket = new PushSocket())
            {
                pushSocket.Bind("tcp://*:5556");

                int i = 0;

                while (true)
                {
                    pushSocket
                        .SendMoreFrame("A") // Topic
                        .SendMoreFrame(i.ToString()) // Message
                        .SendFrame(new byte[] { 0x01, 0x02 }); // Raw

                    //pushSocket.SendFrame(i.ToString()); // Message

                    i++;
                    Thread.Sleep(1000);
                }
            }
           
        }
    }
}
