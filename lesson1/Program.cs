﻿using Server.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Channels;
//cLIENT

#region Some
/*
IPHostEntry iPHost = Dns.Resolve("www.hotmail.com");
Console.WriteLine(iPHost.HostName);
*/


//var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
//var ipAddress = IPAddress.Parse("216.58.212.14");
//var port = 80;
//var endPoint = new IPEndPoint(ipAddress, port);
//try
//{
//    socket.Connect(endPoint);
//    if (socket.Connected)
//    {
//        string str = "GET\r\n\r\n";
//        var bytes = Encoding.ASCII.GetBytes(str);
//        socket.Send(bytes);

//        var length = 0;
//        var buffer = new byte[1024];
//        do
//        {
//            length = socket.Receive(buffer);
//            var response = Encoding.ASCII.GetString(buffer);
//            Console.WriteLine(response);
//            Thread.Sleep(200);
//        } while (0 < length);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//} 

/*
const string uriString =   "https://www.notion.so/English-d53873752a92411e84f2cd8548b5316c";

Uri canonicalUri = new(uriString);
Console.WriteLine(canonicalUri.Fragment);
Console.WriteLine(canonicalUri.AbsolutePath);
Console.WriteLine(canonicalUri.Authority);
Console.WriteLine(canonicalUri.LocalPath);
Console.WriteLine(canonicalUri.DnsSafeHost);*/


#endregion

//ex1
/*
TcpClient client = new TcpClient("127.0.0.1", 12345); // Connect to server
NetworkStream stream = client.GetStream();

byte[] buffer = new byte[256];
int bytesRead = stream.Read(buffer, 0, buffer.Length); // Read data from server

string serverMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
Console.WriteLine("Received from server: " + serverMessage);

client.Close();*/


//EX 2 FROM YOUTUBE

//var port = 27001;
//using TcpClient tcp = new TcpClient("192.168.1.105", port);
//var networkS = tcp.GetStream();
//while (true)
//{
//    Console.WriteLine("Enter message");
//    var message = Console.ReadLine();
//    byte[] buffer = Encoding.UTF8.GetBytes(message);
//    networkS.Write(buffer, 0, buffer.Length);
//    Console.WriteLine("Message sent to server");


//}

/*IPAddress a = IPAddress.Parse("101.102.103.104");
IPEndPoint ep = new IPEndPoint(a, 222); // Port 222
Console.WriteLine(ep.ToString());*/
/*

Uri uri = new Uri("https://www.notion.so/Network-programming-6943123ba74c49a1bc531c394479b1dd");
Uri uri1 = new Uri("https://translate.google.com/?hl=tr&sl=en&tl=az&op=translate");

Console.WriteLine(uri);
Console.WriteLine( );
Console.WriteLine("Scheme "+uri.Scheme);
Console.WriteLine("Host "+uri.Host);
Console.WriteLine("Port "+uri.Port);
Console.WriteLine("AbsolutePath "+uri.AbsolutePath);
Console.WriteLine("Query "+uri.Query);
Console.WriteLine("Fragment " + uri.Fragment);
 
*/

/*string html = await new HttpClient().GetStringAsync("https://www.netflix.com/browse");
string html1 = await new HttpClient().GetStringAsync("https://mystat.itstep.org/main");
Console.WriteLine(html1);*/

//getting process
/*
 try
{

    var client = new HttpClient();
    var response = await client.GetAsync("https://mystat.itstep.org/main");
  
    response.EnsureSuccessStatusCode();
    var html = response.Content.ReadAsStringAsync().Result;
    Console.WriteLine(html);


    Console.ReadKey();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
	 
} */


/*
try
{
    var client = new HttpClient(new HttpClientHandler { UseProxy = false });

    var request = new HttpRequestMessage(HttpMethod.Post, "http://www.albahari.com/EchoPost.aspx");
    request.Content = new StringContent("Hello");
    var httpResponse = await client.SendAsync(request);
    httpResponse.EnsureSuccessStatusCode();
    Console.WriteLine(await httpResponse.Content.ReadAsStringAsync());

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/


try
{

    foreach (var item in Dns.GetHostAddresses("https://www.youtube.com"))
    {
        Console.WriteLine(item.ToString());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//var ip = IPAddress.Parse("192.168.1.105");
//var iPHostEntry =Dns.GetHostEntry(ip);
//Console.WriteLine();
//Console.WriteLine(iPHostEntry);
 

/*
//http server
var listener = new HttpListener();
listener.Prefixes.Add("http://localhost:27001/");
listener.Start();

while (true)
{
    var context = listener.GetContext();
    Console.WriteLine($"{context.Request.RawUrl}");
}*/