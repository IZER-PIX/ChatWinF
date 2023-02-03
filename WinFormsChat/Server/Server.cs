using System.Net;
using System.Net.Sockets;

namespace Server;

public class Server
{
    private TcpListener _listener;

    public List<Client> Clients { get; private set; } = new List<Client>();

    public Server()
    {
        _listener = new TcpListener(IPAddress.Any, 8080);
    }

    public void Listen()
    {
        try
        {
            Console.WriteLine("Start");
            _listener.Start();

            while (true)
            {
                var ClientTcp = _listener.AcceptTcpClient();

                Client client = new Client(ClientTcp, this);
                Clients.Add(client);

                Console.WriteLine($"Client conected: {client.Id}");

                client.Process();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
    }
    public async Task BroadcastMessageAsync(string message)
    {
        foreach (var client in Clients)
        {
            await client.Writer.WriteLineAsync(message);
            await client.Writer.FlushAsync();
        }
    }
}
public class Client
{
    public StreamWriter Writer { get; private set; }
    public StreamReader Reader { get; private set; }
    public string Id { get; private set; } = Guid.NewGuid().ToString();

    private Server _server;

    public Client(TcpClient clientStream, Server server)
    {
        _server = server;
        
        using var stream = clientStream.GetStream();

        Writer = new StreamWriter(stream);
        Reader = new StreamReader(stream);
    }

    public async void Process()
    {
        string message;
        while (true)
        {
            message = await Reader.ReadLineAsync();
            await _server.BroadcastMessageAsync(message);
        }
    }
}