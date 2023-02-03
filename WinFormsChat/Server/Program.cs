namespace Server;
class Program
{
    private static void Main()
    {
        Server server = new();

        
        server.Listen();
    }
}