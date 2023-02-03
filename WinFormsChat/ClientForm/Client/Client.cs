using System;
using System.Net;
using System.Net.Sockets;

namespace ClientForm.Client;

internal class Client
{
    public event Action<string> OnRecive;

    private TcpClient _tcpClient;

    public StreamWriter Writer { get; set; }
    public StreamReader Reader { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public Client()
    {
        _tcpClient = new TcpClient();
        _tcpClient.Connect("127.0.0.1", 8080);

        var stream = _tcpClient.GetStream();
        Writer = new StreamWriter(stream);
        Reader = new StreamReader(stream);
    }
    public async void SendMessage(string message)
    {
        await Writer.WriteLineAsync(message);
        await Writer.FlushAsync();
    }
    private async void ReciveMessageAsync()
    {
        string? message = string.Empty;
        message = await Reader.ReadLineAsync();
        OnRecive?.Invoke(message);
    }
}
