using LearnersDemo.Entities;

namespace LearnersDemo.Services
{

    public class LearnerRepo : ILearnerRepo
    {
        private readonly IList<Learner> _learners = new List<Learner>();

        internal LearnerRepo()
        {
            _learners.Add(GetNewLearner(1, "David", 83));

            _learners.Add(GetNewLearner(2, "Julie", 72));

            _learners.Add(GetNewLearner(3, "Scott", 92));
        }

        private static Learner GetNewLearner(int id, string userName, int coursesCompleted)
        {
            return new Learner(id, userName, coursesCompleted);
        }

        public ILearner GetLearner(int id)
        {
            ILearner learner = new NullLearner();

            bool learnerExists = _learners.Any(l => l.Id == id);

            if (learnerExists)
            {
                learner = _learners.FirstOrDefault(l => l.Id == id)!;
            }

            return learner;
        }

    }

}
