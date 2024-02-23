using System.Net.Security;
using System;
namespace appPractice
{
    class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine($"Starting server on {HHTPServer.port}!");
            HHTPServer server = new HHTPServer(8080);
            server.Start();
        }
    }
}