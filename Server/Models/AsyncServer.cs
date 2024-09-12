using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models;

//bax

class AsyncServer
{
    static TcpListener listener;

    static async Task Main()
    {
        listener = new TcpListener(IPAddress.Any, 12345);
        listener.Start();
        Console.WriteLine("Server started...");

        while (true)
        {
            TcpClient client = await listener.AcceptTcpClientAsync(); // Asynchronously accept a client
            Console.WriteLine("Client connected!");

            // Handle client in a separate task
            _ = HandleClientAsync(client);
        }
    }

    static async Task HandleClientAsync(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[256];
        int bytesRead;

        while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
        {
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received: " + message);

            // Echo the message back to the client
            byte[] response = Encoding.UTF8.GetBytes("Server received: " + message);
            await stream.WriteAsync(response, 0, response.Length);
        }

        Console.WriteLine("Client disconnected.");
        client.Close();
    }
}
