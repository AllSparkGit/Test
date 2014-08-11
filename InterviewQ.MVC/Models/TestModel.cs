using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewQ.MVC.Models
{
    [Serializable]
    public class TestModel
    {
        private QuestionModel _currenQuestionModel;

        public int TestID { get; set; }
        public string TestName { get; set; }

        public string Instructions { get; set; }

        public double TestTime { get; set; }
        
        public QuestionModel CurrenQuestionModel
        {
            get
            {
                if (_currenQuestionModel == null &&
                    Questions != null && 
                    Questions.Count > 0)
                    _currenQuestionModel = Questions.First();
                
                return _currenQuestionModel;
            }
            set { _currenQuestionModel = value; }
        }

        public List<QuestionModel> Questions { get; set; }
    }

    public class QuestionModel
    {
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public bool HasMultipleAnswers { get; set; }
        public IList<PossibleAnswerModel> PossibleAnswers { get; set; }   
    }

    public class PossibleAnswerModel
    {
        public bool IsSelected { get; set; }
        public string DisplayText { get; set; }
    }
}