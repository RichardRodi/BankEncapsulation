using BankEncapsulation.Accounts;
using BankEncapsulation.Printings;
using System.ComponentModel.Design;

namespace BankEncapsulation.System
{

    public static class ATM
    {
        
        public static void StartAtm()
            
        
        {
            var newBankAccount = new BaseAccount();

            Printing.PrintTitle();
            GetUserBalance(newBankAccount);
            Deposit(newBankAccount);
            var result = DoYouWantToContinue();

            if (result is true) Continue();

            else
                Exit();
        }


        private static void Deposit(BaseAccount bankAccount)
        {
            Console.WriteLine("Would you like to add to your balance?: Yes or No");
            var answer2 = Console.ReadLine();
            if (answer2 == "Yes" )
            {
                Console.WriteLine("Great how much will you deposit today?\n");

                var amountToDeposit = Console.ReadLine();
                if (!string.IsNullOrEmpty(amountToDeposit))
                {
                    double deposit = double.Parse(amountToDeposit);
                    bankAccount.Deposit(deposit);
                }
            }

            Console.WriteLine($"Thank you! Your New Balance is: {bankAccount.GetBalance()} dollars\n");
        }

        private static void GetUserBalance(BaseAccount bankAccount)
        {
            Console.WriteLine("\n Would you like to get your balance?: Yes or No\n");
            var answer = (Console.ReadLine());
            if (answer == "Yes")
            {
                Console.WriteLine(bankAccount.GetBalance());
            }
        }

        public static bool DoYouWantToContinue()
        { 
        Console.WriteLine("Would you like to do anything else today: Yes or No\n");
            var answer = Console.ReadLine();
            if (answer == "Yes")

                return true;

            else 
               
            {
                return false;
            }
        }
           
        private static void Exit()
        {
            Environment.Exit(0);
        }

        private static void Continue()
        {
           
                StartAtm();
            
        }
    }
}
