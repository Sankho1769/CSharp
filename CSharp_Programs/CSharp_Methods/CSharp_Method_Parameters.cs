using System;
class Program {
    static void Greet(string name, int age) {
        Console.WriteLine($"Hello {name}, age {age}");
    }
    static void Main() {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Greet(name, age);
    }
}