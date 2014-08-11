using System;
using System.Linq;
using System.Text;

namespace InterviewQ.Business.Contracts
{
    public interface ITestInfo
    {
        Guid TestID { get; }
        string TestName { get; }

    }
}
