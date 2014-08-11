using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterviewQ.Business.Contracts;

namespace InterviewQ.Business.Entities
{
    public class Test:ITest
    {

        #region ITest Members

        public ICollection<IQuestion> Questions
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region ITestInfo Members

        public Guid TestID { get; private set; }

        public string TestName { get; private set; }

        #endregion
    }
}
