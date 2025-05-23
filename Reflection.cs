
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var account = new BankAccount("A123", "Issam A.", 0);
        Type t = typeof(BankAccount);
        Console.WriteLine(t);

        // account.Deposit(100); // الطريقة العادية

        // استخدام Reflection لاستدعاء Deposit
        Type[] parametersType = { typeof(decimal) };
        MethodInfo method = t.GetMethod("Deposit", parametersType);
        method.Invoke(account, new object[] { 500m }); // مشابه لي account.Deposit(100)

        Console.WriteLine(account);
        Console.ReadKey();
    }

    private static void Account_OnNegativeBalance(object sender, EventArgs e)
    {
        var bankAccount = (BankAccount)sender;
        Console.WriteLine("NEGATIVE BALANCE!!!");
    }
}

public class BankAccount
{
    public string AccountNumber { get; }
    public string OwnerName { get; }
    public decimal Balance { get; private set; }

    public event EventHandler OnNegativeBalance;

    public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override string ToString()
    {
        return $"Account: {AccountNumber}, Owner: {OwnerName}, Balance: {Balance:C}";
    }
}