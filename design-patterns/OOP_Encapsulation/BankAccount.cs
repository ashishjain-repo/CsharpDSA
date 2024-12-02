namespace GoodExample
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }
        public decimal GetBalance()
        {
            return _balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            this._balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive");
            }
            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient Funds");
            }
            this._balance -= amount;
        }
    }
}