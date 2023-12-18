using HW01_ClientUDP;

internal class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 15; i++)
        {
            UDPClient.SendMessage("kvo", i);
        }
        Console.ReadKey();

    }
}
