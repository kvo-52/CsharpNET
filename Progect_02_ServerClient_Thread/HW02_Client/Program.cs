
using HW02_Client;

public class Program
{
    static void Main(string[] args)
    {
        new Task(() => Client.SendMessage("kvo")).RunSynchronously();
        Console.ReadKey();
    }
}
