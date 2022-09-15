using LearnersDemo.Entities;

namespace LearnersDemo.Services
{
    public interface ILearnerRepo
    {
        ILearner GetLearner(int id);
    }
}