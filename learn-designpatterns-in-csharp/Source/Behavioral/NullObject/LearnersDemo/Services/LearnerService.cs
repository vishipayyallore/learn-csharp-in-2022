using LearnersDemo.Entities;

namespace LearnersDemo.Services
{

    public class LearnerService
    {
        readonly LearnerRepo _repo = new();

        public ILearner GetCurrentLearner()
        {
            // go get the Learner's id from a JWT token cookie
            // or by some other appropriate means

            int learnerId = 1;

            var learner = _repo.GetLearner(learnerId);

            if (learner == null) throw new NullReferenceException();

            return learner;
        }

        class LearnerRepo
        {
            readonly IList<Learner> _learners = new List<Learner>();

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

            internal ILearner GetLearner(int id)
            {
                bool learnerExists = _learners.Any(l => l.Id == id);

                if (learnerExists)
                    return _learners.FirstOrDefault(l => l.Id == id);

                return null;
            }
        }

    }

}
