using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace _2048Game
{
    static public class Server
    {
        static public string Server_find(string name)
        {
            //确定端口号
            int port = 6000;

            //设定连接IP
            string host = "127.0.0.1";

            //将IP地址字符串转化为IP地址实例
            IPAddress ip = IPAddress.Parse(host);

            //将网络端点表示为 IP 地址和端口号
            IPEndPoint ipe = new IPEndPoint(ip, port);

            //建立Socket 
            //addressFamily 参数指定 Socket 类使用的寻址方案
            //socketType 参数指定 Socket 类的类型
            //protocolType 参数指定 Socket 使用的协议。 
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //socket与本地终结点建立关联
            socket.Bind(ipe);
            while (true)
            {
                //开始监听端口
                socket.Listen(0);

                //Console.WriteLine("服务已开启,请等待....." + DateTime.Now.ToString());

                //为新建的连接建立新的Socket目的为客户端将要建立连接
                Socket serverSocket = socket.Accept();
                //Console.WriteLine("连接已建立......" + DateTime.Now.ToString());

                string recStr = string.Empty;
                //定义缓冲区用于接收客户端的数据
                byte[] recbyte = new byte[1024];

                //返回接收到的字节数
                int bytes = serverSocket.Receive(recbyte, recbyte.Length, 0);

                //将接收到的字节抓获年华为string
                //参数一:字节数组 参数二:起始索引 参数三:总长度
                recStr += Encoding.Unicode.GetString(recbyte, 0, bytes);
   
                //Console.WriteLine("服务器接收到客户端的信息:" + recStr + " " + DateTime.Now.ToString() + "\n\n");

                
                //服务端给客户端回送消息
                string strSend = "玩家："+name+"向您发起邀请";
                byte[] sendByte = new byte[1024];
                //将发送的字符串转换为byte[]
                sendByte = Encoding.Unicode.GetBytes(strSend);

                //服务端发送数据
                serverSocket.Send(sendByte, sendByte.Length, 0);

                serverSocket.Close();

                MainForm.oppname = recStr.Substring(3,4);

                return recStr ;

                /*string s = "1234abc123444555efcdeeee";
                int i = s.IndexOf("abc") + 1;
                int j = s.IndexOf("ef");
                string str = s.Substring(i, j - i + 2);*/
            }
        }

    }
}
