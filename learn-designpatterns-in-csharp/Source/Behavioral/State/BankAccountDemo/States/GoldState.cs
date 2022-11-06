using BankAccountDemo.Contexts;

using static System.Console;

namespace BankAccountDemo.States
{
    /// <summary>
    /// ConcreteState
    /// </summary>
    public class GoldState : BankAccountState
    {
        public GoldState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;

            BankAccount = bankAccount;
        }

        /// <summary>
        /// Handle a deposit
        /// </summary> 
        public override void Deposit(decimal amount)
        {
            WriteLine($"In {GetType()}, depositing {amount} + 10% bonus: {amount / 10}");
            
            Balance += amount + (amount / 10);
        }

        /// <summary>
        /// Handle withdrawing
        /// </summary> 
        public override void Withdraw(decimal amount)
        {
            WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
            
            // change state to overdrawn when withdrawing results in less than zero
            Balance -= amount;
            
            if (Balance < 1000 && Balance >= 0)
            {
                // change state to regular
                BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
            }
            else if (Balance < 0)
            {
                // change state to overdrawn
                BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }


}
