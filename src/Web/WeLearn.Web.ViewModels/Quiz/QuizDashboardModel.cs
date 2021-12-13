using System.Collections.Generic;
using WeLearn.Web.ViewModels.Examination;

namespace WeLearn.Web.ViewModels.Quiz
{
    public class QuizDashboardModel
    {
        public IEnumerable<QuizViewModel> AllQuizzesViewModels { get; set; }
        
        public IEnumerable<ExaminationViewModel> ExaminationViewModels { get; set; }
    }
}
