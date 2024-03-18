using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class History
    {
        public History()
        {
            HistoryDetails = new HashSet<HistoryDetail>();
        }

        public int HistoryId { get; set; }

        public int Score { get; set; }

        public DateTime? HistoryDate { get; set; }
        public TimeSpan? HistoryTime { get; set; }
        public int? UserId { get; set; }
        public int? LicenseId { get; set; }
        public int? SetId { get; set; }

        public virtual License? License { get; set; }
        public virtual Set? Set { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<HistoryDetail> HistoryDetails { get; set; }
    }
}
