using System.Net.Sockets;
using System.Net;
using System.Text;
using Server.Models;
//SERVER

//ex1
/*
TcpListener listener = new TcpListener(IPAddress.Any, 12345);
listener.Start();
Console.WriteLine("Server started...");

while (true)
{
    TcpClient client = listener.AcceptTcpClient(); // Wait for a client to connect
    NetworkStream stream = client.GetStream();

    byte[] buffer = Encoding.UTF8.GetBytes("Hello, Client!");
    stream.Write(buffer, 0, buffer.Length); // Send data to client
    Console.WriteLine("Message sent to client.");

    client.Close();
}
*/


//EX 2 FROM YOUTUBE
//CREATING SERVER CLASS

//TcpClient sınıfı doğrudan bir IPEndPoint ile başlatılamaz.
//try
//{

//var server = new Server1();

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//} 

var ip = IPAddress.Parse("192.168.1.105");
var port = 27001;
var ep =new   IPEndPoint(ip, port);
var socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);

socket.Bind(ep);
EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
