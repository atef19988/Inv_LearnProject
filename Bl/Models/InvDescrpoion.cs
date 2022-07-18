using System;
using System.Collections.Generic;

namespace Bl.Models
{
    public partial class InvDescrpoion
    {
        public int Id { get; set; }
        public int? InvId { get; set; }
        public int? ProId { get; set; }
        public decimal? PriceSale { get; set; }
        public decimal? Qty { get; set; }

        public virtual InvHead? Inv { get; set; }
        public virtual Procduct? Pro { get; set; }
    }
}
