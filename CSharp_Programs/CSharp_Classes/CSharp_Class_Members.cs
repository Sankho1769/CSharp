using System;
class Student {
    public string Name;
    public int Marks;
    public void Show() => Console.WriteLine($"{Name}: {Marks}");
}
class Program {
    static void Main() {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter marks: ");
        int marks = int.Parse(Console.ReadLine());
        Student s = new Student { Name = name, Marks = marks };
        s.Show();
    }
}