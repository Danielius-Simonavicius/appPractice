using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace appPractice;

public class HHTPServer
{
    private static TcpListener Listener;
    public  static int port = 8080;
    Boolean running = false;
    //private static IPAddress localAddr = IPAddress.Parse("127.0.0.1");

    //web server path
    private static string WebServerPath = @"WebServer";

    public HHTPServer(int port){
        port = port;
        Listener = new TcpListener(IPAddress.Any, port);
    }
    public void Start(){
        Thread serverThread = new Thread(new ThreadStart(Run));
        serverThread.Start();
    }

    private void Run(){
        running = true;
        Listener.Start();
        while(running){
            Console.WriteLine("Waiting for connection...");

            TcpClient client = Listener.AcceptTcpClient();

            Console.WriteLine("Client connected!");
            HandleClient(client);
            client.Close();
        }

        running = false;

        Listener.Stop();
    }

    private void HandleClient(TcpClient client){
        StreamReader reader = new StreamReader(client.GetStream());

        String msg = "";

        while(reader.Peek() !=-1){
            msg += reader.ReadLine() + "\n";
        }

        Console.WriteLine("Request: \n" + msg);
    }

    // static void Main(string[] args)
    // {
    //     myListener = new TcpListener(localAddr, port);
    //     myListener.Start();
    //     Console.WriteLine($"Web Server Running on {localAddr.ToString()} on port {port}... Press ^C to Stop...");
    //     Thread th = new Thread(new ThreadStart(StartListen));
    //     th.Start();
    // }

    // private static void StartListen()
    // {
    //     while (true)
    //     {
    //         TcpClient client = myListener.AcceptTcpClient();
    //         NetworkStream stream = client.GetStream();
    //         client.Close();
    //     }
    // }
}
