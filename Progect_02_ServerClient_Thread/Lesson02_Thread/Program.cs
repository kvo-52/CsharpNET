using Lesson02_Thread;

internal class Program
{
    static async Task Main(string[] args)
    {
        //Task1
        var Task1 = Lesson2.Task1();
        var Task2 = Lesson2.Task2();
        int num1 = Task1.Result;
        int num2 = await Task2;
        Console.WriteLine(num1 + num2);

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }
}
