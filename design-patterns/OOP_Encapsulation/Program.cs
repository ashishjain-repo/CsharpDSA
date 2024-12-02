using BadExample;
using GoodExample;
public class Program
{
    public static void Main(string[] args)
    {
        BadBankAccount badAccount = new BadBankAccount();
        badAccount.Balance = 100;

        BankAccount goodAccount = new BankAccount(100);
        System.Console.WriteLine(goodAccount.GetBalance());
        goodAccount.Deposit(50);
        goodAccount.Withdraw(101);
        System.Console.WriteLine(goodAccount.GetBalance());
    }
}