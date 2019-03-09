using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace _2048Game
{
    static public class Customer
    {
        static int port = 6000;                          //监听端口号
        static string host = "127.0.0.1";                //连接服务端IP
        static IPAddress ip = IPAddress.Parse(host);     //将IP地址转换为IP实例
        static IPEndPoint ipe = new IPEndPoint(ip, port);//将网络端点表示为 IP 地址和端口号
        static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//建立客户端Socket

        static public string Customer_open(string name)
        {

            clientSocket.Connect(ipe);                   //客户端开始连接服务端

            string sendStr = "玩家:" + name + " 接受了您的邀请:战斗吧，武士!!!";            //向服务器发送消息
            byte[] sendBytes = Encoding.Unicode.GetBytes(sendStr);
            clientSocket.Send(sendBytes);


            string revStr = "";                          //接收来自服务器的消息
            byte[] revBytes = new byte[4096];
            int bytes = clientSocket.Receive(revBytes, revBytes.Length, 0);

            revStr += Encoding.Unicode.GetString(revBytes, 0, bytes);


            clientSocket.Close();
            //Console.WriteLine("来自服务端的回应:{0}", revStr);
            return revStr;


        }
    }
}
