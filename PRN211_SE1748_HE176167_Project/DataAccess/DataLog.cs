using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataLog
    {
        public Question Question { get; set; }
        public Answer Answer { get; set; }

        public DataLog(Question question, Answer answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}
