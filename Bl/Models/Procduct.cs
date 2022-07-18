using System;
using System.Collections.Generic;

namespace Bl.Models
{
    public partial class Procduct
    {
        public int Id { get; set; }
        public string? ProName { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal? Qty { get; set; }
    }
}
