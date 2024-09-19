using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models;

public class Server1
{
    private TcpListener tcpListener { get; set; }
    public Server1()
    {
        StartServer();
    }

    private void StartServer()
    {
        try
        {




            Thread thread = new Thread(() =>
            {
                Console.WriteLine("Waitin for client");
                int port = 27001;
                var ip = IPAddress.Parse("192.168.1.105");
                var endpoint = new IPEndPoint(ip, port);
                var listener = new TcpListener(endpoint);

                listener.Start();
                byte[] buffer = new byte[1024];
                string recived;
                using var client = listener.AcceptTcpClient();
                var networkstream = client.GetStream();

                int readtotal;
                while ((readtotal = networkstream.Read(buffer, 0, buffer.Length)) != 0)
                {

                    recived = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                    Console.WriteLine($"RECIVED: {recived}");
                }
                Console.WriteLine("Accepted");
                client.Close();
            });
            thread.Start();





        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }




    }
}
