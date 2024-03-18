using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            HistoryDetails = new HashSet<HistoryDetail>();
        }

        public int QuestionId { get; set; }
        public string? QuestionDescription { get; set; }
        public string? QuestionImage { get; set; }
        public int? LicenseId { get; set; }
        public int? TopicId { get; set; }
        public int SetId { get; set; }
        public string? QuestionExplain { get; set; }

        public virtual License? License { get; set; }
        public virtual Set? Set { get; set; }
        public virtual Topic? Topic { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<HistoryDetail> HistoryDetails { get; set; }
    }
}
