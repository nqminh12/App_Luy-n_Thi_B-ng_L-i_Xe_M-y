using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Questions = new HashSet<Question>();
        }

        public Topic(int topicId, string? topicName)
        {
            TopicId = topicId;
            TopicName = topicName;
        }

        public int TopicId { get; set; }
        public string? TopicName { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
