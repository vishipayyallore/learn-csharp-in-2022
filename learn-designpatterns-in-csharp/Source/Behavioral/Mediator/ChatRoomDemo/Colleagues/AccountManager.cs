using static System.Console;

namespace ChatRoomDemo.Colleagues
{
    /// <summary>
    /// ConcreteColleague
    /// </summary>
    public class AccountManager : TeamMember
    {
        public AccountManager(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Write($"{nameof(AccountManager)} {Name} received: ");

            base.Receive(from, message);
        }
    }

}
