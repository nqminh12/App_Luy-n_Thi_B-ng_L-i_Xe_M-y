using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class License
    {
        public License()
        {
            Histories = new HashSet<History>();
            Questions = new HashSet<Question>();
        }

        public int LicenseId { get; set; }
        public string? LicenseName { get; set; }

        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
