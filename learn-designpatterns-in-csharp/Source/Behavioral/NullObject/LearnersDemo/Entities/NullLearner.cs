namespace LearnersDemo.Entities
{

    public class NullLearner : ILearner
    {
        public int Id { get; } = -1;

        public string UserName => "No Name";

        public int CoursesCompleted { get; } = 0;
    }

}
