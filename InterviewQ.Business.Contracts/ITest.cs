using System.Collections.Generic;

namespace InterviewQ.Business.Contracts
{
    public interface ITest : ITestInfo
    {
        ICollection<IQuestion> Questions { get; }
    }
}