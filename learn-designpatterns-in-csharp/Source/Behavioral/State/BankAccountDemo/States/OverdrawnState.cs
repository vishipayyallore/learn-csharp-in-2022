using BankAccountDemo.Contexts;

using static System.Console;

namespace BankAccountDemo.States
{
    /// <summary>
    /// ConcreteState
    /// </summary>
    public class OverdrawnState : BankAccountState
    {
        public OverdrawnState(decimal balance, BankAccount bankAccount)
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

            if (Balance >= 0)
            {
                // change state to regular
                BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
            }
        }

        /// <summary>
        /// Handle withdrawing
        /// </summary> 
        public override void Withdraw(decimal amount)
        {
            // cannot withdraw
            WriteLine($"In {GetType()}, cannot withdraw, balance {Balance}");
        }
    }


}
