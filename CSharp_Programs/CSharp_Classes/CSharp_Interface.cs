using System;
interface IAnimal {
    void Speak();
}
class Dog : IAnimal {
    public void Speak() => Console.WriteLine("Dog says: Woof!");
}
class Program {
    static void Main() {
        Dog d = new Dog();
        d.Speak();
    }
}