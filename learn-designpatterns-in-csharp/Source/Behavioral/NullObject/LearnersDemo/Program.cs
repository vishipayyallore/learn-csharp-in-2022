using LearnersDemo.Entities;
using LearnersDemo.Services;
using LearnersDemo.View;

LearnerService learnerService = new LearnerService();
ILearner learner = learnerService.GetCurrentLearner();

LearnerView view = new LearnerView(learner);
view.RenderView();
