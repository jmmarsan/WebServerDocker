using System;
using System.Net;

namespace WebServerDocker
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kubia server starting...");
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://*:8080/");
            listener.Start();
            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                Console.WriteLine("¡Received request from " + context.Request.RemoteEndPoint + "!");
                context.Response.StatusCode = 200;
                string responseString = "¡You've hit " + Environment.MachineName + "!\n";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.Close();
            }
        }
    }
}


