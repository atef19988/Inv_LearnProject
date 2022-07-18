using System;
using System.Collections.Generic;

namespace Bl.Models
{
    public partial class Customer
    {
        public Customer()
        {
            InvHeads = new HashSet<InvHead>();
        }

        public int Id { get; set; }
        public string? CustName { get; set; }
        public decimal? OpiningBl { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }

        public virtual ICollection<InvHead> InvHeads { get; set; }
    }
}
