using System;
using System.Collections.Generic;

namespace InterviewQ.Business.Contracts
{
    public interface IQuestionAnswer
    {
        Guid QuestionID { get; }
        ICollection<int> Answers { get; set; }
    }
}