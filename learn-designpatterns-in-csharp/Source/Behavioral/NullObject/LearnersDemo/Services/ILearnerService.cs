using LearnersDemo.Entities;

namespace LearnersDemo.Services
{
    public interface ILearnerService
    {
        ILearner GetCurrentLearner(int learnerId);
    }
}