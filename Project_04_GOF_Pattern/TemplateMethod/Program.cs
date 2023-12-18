﻿abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Step1();
        Step2();
        Step3();
    }

    protected abstract void Step1();
    protected abstract void Step2();
    protected abstract void Step3();
}

class ConcreteClass : AbstractClass
{
    protected override void Step1()
    {
        Console.WriteLine("Шаг 1");
    }

    protected override void Step2()
    {
        Console.WriteLine("Шаг 2");
    }

    protected override void Step3()
    {
        Console.WriteLine("Шаг 3");
    }
}

class Program
{
    static void Main(string[] args)
    {
        AbstractClass template = new ConcreteClass();
        template.TemplateMethod();
    }
}
