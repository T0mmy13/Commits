using System;

class Program
{
    static void Main(string[] args)
    {
        string name = string.Empty;
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty. Please try again.");
            }
        }
        Console.WriteLine($"Hello, {name}!");
    }
}
