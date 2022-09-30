using LearnersDemo.Entities;
using LearnersDemo.Services;
using LearnersDemo.View;

using static System.Console;

Title = "Design Pattern - Null Object";

ILearnerService learnerService = new LearnerService();

for (int i = 1; i < 5; i++)
{
    ILearner learner = learnerService.GetCurrentLearner(i);

    ILearnerView view = new LearnerView(learner);

    view.RenderView();
}
