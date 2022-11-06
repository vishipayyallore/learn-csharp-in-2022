using BankAccountDemo.Contexts;

using static System.Console;

namespace BankAccountDemo.States
{
    /// <summary>
    /// ConcreteState
    /// </summary>
    public class RegularState : BankAccountState
    {
        public RegularState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;

            BankAccount = bankAccount;
        }

        /// <summary>
        /// Handle a deposit
        /// </summary> 
        public override void Deposit(decimal amount)
        {
            WriteLine($"In {GetType()}, depositing {amount}");

            Balance += amount;

            if (Balance >= 1000)
            {
                // change state to gold
                BankAccount.BankAccountState = new GoldState(Balance, BankAccount);
            }
        }

        /// <summary>
        /// Handle withdrawing
        /// </summary> 
        public override void Withdraw(decimal amount)
        {
            WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");

            // change state to overdrawn when withdrawing results in less than zero
            Balance -= amount;

            if (Balance < 0)
            {
                // change state to overdrawn
                BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }


}
