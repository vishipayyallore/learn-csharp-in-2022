using LearnersDemo.Entities;
using LearnersDemo.Services;
using LearnersDemo.View;

ILearnerService learnerService = new LearnerService();

for (int i = 1; i < 5; i++)
{
    ILearner learner = learnerService.GetCurrentLearner(i);

    LearnerView view = new(learner);
    view.RenderView();
}
