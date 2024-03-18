using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Answer
    {
        public Answer()
        {
            HistoryDetails = new HashSet<HistoryDetail>();
        }

        public int AnswerId { get; set; }
        public string? AnswerDescription { get; set; }
        public string? AnswerImage { get; set; }
        public int AnswerType { get; set; }
        public int? QuestionId { get; set; }

        public virtual Question? Question { get; set; }
        public virtual ICollection<HistoryDetail> HistoryDetails { get; set; }
    }
}
