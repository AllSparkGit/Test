using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterviewQ.Business.Contracts;

namespace InterviewQ.Business.Entities
{
    public class Interviewee
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public ICollection<ITest> Tests { get; set; }
    }
}
