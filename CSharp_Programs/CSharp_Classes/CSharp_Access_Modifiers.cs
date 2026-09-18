using System;
class Account {
    private double balance;
    public void SetBalance(double value) { balance = value; }
    public double GetBalance() { return balance; }
}
class Program {
    static void Main() {
        Console.Write("Enter balance: ");
        double value = double.Parse(Console.ReadLine());
        Account a = new Account();
        a.SetBalance(value);
        Console.WriteLine("Balance = " + a.GetBalance());
    }
}