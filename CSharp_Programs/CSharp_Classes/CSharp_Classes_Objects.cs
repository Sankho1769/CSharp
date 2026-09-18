using System;
class Box {
    public int Value;
}
class Program {
    static void Main() {
        Console.Write("Enter value: ");
        Box b = new Box();
        b.Value = int.Parse(Console.ReadLine());
        Console.WriteLine("Object value = " + b.Value);
    }
}