using System;
using System.Collections.Generic;

namespace InvBackEnd.Models
{
    public partial class InvheadTb
    {
        public InvheadTb()
        {
            InvDescrptionTbs = new HashSet<InvDescrptionTb>();
        }

        public int Id { get; set; }
        public int? CustId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? ShepingEx { get; set; }

        public virtual CustomerTb? Cust { get; set; }
        public virtual ICollection<InvDescrptionTb> InvDescrptionTbs { get; set; }
    }
}
