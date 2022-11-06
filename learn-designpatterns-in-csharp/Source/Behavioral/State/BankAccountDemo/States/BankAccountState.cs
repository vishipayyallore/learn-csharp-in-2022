using BankAccountDemo.Contexts;

namespace BankAccountDemo.States
{

    /// <summary>
    /// State
    /// </summary>
    public abstract class BankAccountState
    {
        public BankAccount BankAccount { get; protected set; } = null!;

        public decimal Balance { get; protected set; }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);
    }

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
            Console.WriteLine($"In {GetType()}, depositing {amount}");
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
            Console.WriteLine($"In {GetType()}, cannot withdraw, balance {Balance}");
        }
    }


}
