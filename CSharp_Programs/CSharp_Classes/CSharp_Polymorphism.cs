using System;
class Shape {
    public virtual void Draw() => Console.WriteLine("Shape");
}
class Circle : Shape {
    public override void Draw() => Console.WriteLine("Circle");
}
class Program {
    static void Main() {
        Console.Write("Enter 1 for Shape or 2 for Circle: ");
        int choice = int.Parse(Console.ReadLine());
        Shape s = choice == 2 ? new Circle() : new Shape();
        s.Draw();
    }
}