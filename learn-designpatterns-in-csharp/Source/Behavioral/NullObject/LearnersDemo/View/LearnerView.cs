using LearnersDemo.Entities;

using static System.Console;

namespace LearnersDemo.View
{

    public class LearnerView : ILearnerView
    {
        private readonly ILearner _learner;

        public LearnerView(ILearner learner)
        {
            //if (learner == null) throw new ArgumentNullException();
            //if (learner.UserName == null) throw new ArgumentNullException();

            _learner = learner;
        }

        public void RenderView()
        {
            WriteLine($"User Name: {_learner.UserName}");
            WriteLine($"Courses Completed: {_learner.CoursesCompleted}");
        }
    }

}
