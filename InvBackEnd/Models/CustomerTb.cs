using System;
using System.Collections.Generic;

namespace InvBackEnd.Models
{
    public partial class CustomerTb
    {
        public CustomerTb()
        {
            InvheadTbs = new HashSet<InvheadTb>();
        }

        public int Id { get; set; }
        public string? CustName { get; set; }
        public string? Phone { get; set; }
        public string? OpiningBl { get; set; }

        public virtual ICollection<InvheadTb> InvheadTbs { get; set; }
    }
}
