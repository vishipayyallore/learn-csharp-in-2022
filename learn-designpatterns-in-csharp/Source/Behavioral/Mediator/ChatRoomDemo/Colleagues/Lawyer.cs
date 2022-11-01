namespace ChatRoomDemo.Colleagues
{
    /// <summary>
    /// ConcreteColleague
    /// </summary>
    public class Lawyer : TeamMember
    {
        private List<TeamMember> _teamMembersInChat = new();

        public Lawyer(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write($"{nameof(Lawyer)} {Name} received: ");
            base.Receive(from, message);
        }
    }

}
