using System;
class Person {
    public string Name;
    public void Show() => Console.WriteLine("Person: " + Name);
}
class Program {
    static void Main() {
        Console.Write("Enter name: ");
        Person p = new Person { Name = Console.ReadLine() };
        p.Show();
    }
}