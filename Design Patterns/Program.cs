using System;
namespace Design_Patterns;
class Program
{
    static void Main(string[] args)
    {
        //Singleton 
        Console.WriteLine("========== Singleton ==========");
        Singleton s1 = Singleton.GetSingleton();
        Singleton s2 = Singleton.GetSingleton();

        if (s1 == s2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }

        //Adapter
        Console.WriteLine("========== Adapter ==========");

        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        Console.WriteLine("Adaptee interface is incompatible with the client.");
        Console.WriteLine("But with adapter client can call it's method.");

        Console.WriteLine(target.GetRequest());

        //Iterator 
        Console.WriteLine("========== Iterator  ==========");

        var collection = new WordsCollection();
        collection.AddItem("First");
        collection.AddItem("Second");
        collection.AddItem("Third");

        Console.WriteLine("Straight traversal:");

        foreach (var element in collection)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("\nReverse traversal:");

        collection.ReverseDirection();

        foreach (var element in collection)
        {
            Console.WriteLine(element);
        }
    }
}
