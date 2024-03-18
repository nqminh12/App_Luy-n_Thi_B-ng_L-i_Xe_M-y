using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Set
    {
        public Set()
        {
            Histories = new HashSet<History>();
            Questions = new HashSet<Question>();
        }

        public int SetId { get; set; }
        public int SetNumber { get; set; }
        public string? SetName { get; set; }

        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
