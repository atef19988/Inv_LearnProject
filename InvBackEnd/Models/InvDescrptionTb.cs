using System;
using System.Collections.Generic;

namespace InvBackEnd.Models
{
    public partial class InvDescrptionTb
    {
        public int Id { get; set; }
        public int? InvId { get; set; }
        public int? ProductId { get; set; }
        public decimal? PriceSale { get; set; }
        public decimal? Qty { get; set; }

        public virtual InvheadTb? Inv { get; set; }
        public virtual ProductTb? Product { get; set; }
    }
}
