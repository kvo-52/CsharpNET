using HW02_Server;

internal class Program
{
    static void Main(string[] args)
    {
        var t = Task.Run(() => Server.ServerUDP());
        Task.WaitAll(t);
    }
}
