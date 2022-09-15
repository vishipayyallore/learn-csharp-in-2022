using LearnersDemo.Entities;

namespace LearnersDemo.Services
{

    public class LearnerService : ILearnerService
    {
        readonly LearnerRepo _repo = new();

        public ILearner GetCurrentLearner(int learnerId)
        {
            //var learner = _repo.GetLearner(learnerId);
            //if (learner == null) throw new NullReferenceException();
            //return learner;

            return _repo.GetLearner(learnerId);
        }

    }

}
