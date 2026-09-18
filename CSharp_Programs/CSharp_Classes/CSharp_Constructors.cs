using System;
class Person {
    public string Name;
    public Person(string name) { Name = name; }
}
class Program {
    static void Main() {
        Console.Write("Enter name: ");
        Person p = new Person(Console.ReadLine());
        Console.WriteLine("Name = " + p.Name);
    }
}