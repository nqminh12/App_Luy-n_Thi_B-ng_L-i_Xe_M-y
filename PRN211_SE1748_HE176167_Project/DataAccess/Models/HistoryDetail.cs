using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class HistoryDetail
    {
        public int HistoryDetailId { get; set; }
        public int? HistoryId { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }

        public virtual Answer? Answer { get; set; }
        public virtual History? History { get; set; }
        public virtual Question? Question { get; set; }
    }
}
