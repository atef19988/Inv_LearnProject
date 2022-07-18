using System;
using System.Collections.Generic;

namespace InvBackEnd.Models
{
    public partial class ProductTb
    {
        public ProductTb()
        {
            InvDescrptionTbs = new HashSet<InvDescrptionTb>();
        }

        public int Id { get; set; }
        public string? ProductName { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal? Qty { get; set; }

        public virtual ICollection<InvDescrptionTb> InvDescrptionTbs { get; set; }
    }
}
