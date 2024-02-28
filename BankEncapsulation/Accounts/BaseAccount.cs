namespace BankEncapsulation.Accounts
{
    public class BaseAccount

    {
        // Private Fields & Props //
        private double _balance = 0;

        // Public Fields & Properties //
        public string AccountName { get; set; } = string.Empty;

        // CTOR //
        public BaseAccount() {}

        // Public Methods //
        public void Deposit(double moneyToAdd) => _balance += moneyToAdd;

        public double GetBalance() => _balance;

        // Private Methods //

    }



}
