using System;
using System.Collections.Generic;

namespace Bl.Models
{
    public partial class InvHead
    {
        public int Id { get; set; }
        public int? CustId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? ShepingEx { get; set; }

        public virtual Customer? Cust { get; set; }
    }
}
