using System;
using System.Collections.Generic;

namespace InterviewQ.Business.Contracts
{
    public interface IQuestion
    {
        Guid QuestionID { get; }
        string Question { get; }
        ICollection<IQuestionOption> Options { get; }
        ICollection<int> Answers { get; set; }
        ICollection<IQuestionCategory> Categories { get; }
        IWeight Difficulty { get; }
    }
}