using ChatRoomDemo.Mediators;

namespace ChatRoomDemo.Colleagues
{
    /// <summary>
    /// Colleague
    /// </summary>
    public abstract class TeamMember
    {
        public string Name { get; set; }

        private IChatRoom? _chatroom;

        public TeamMember(string name)
        {
            Name = name;
        }

        internal void SetChatroom(IChatRoom chatRoom)
        {
            _chatroom = chatRoom;
        }

        public void Send(string message)
        {
            _chatroom?.Send(Name, message);
        }

        public void Send(string to, string message)
        {
            _chatroom?.Send(Name, to, message);
        }

        public void SendTo<T>(string message) where T : TeamMember
        {
            _chatroom?.SendTo<T>(Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"message from {from} to {Name}: {message}");
        }
    }

}
