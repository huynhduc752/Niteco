using System;
using System.Collections.Generic;

#nullable disable

namespace Niteco.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? CustomerId { get; set; }
        public int? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Desc { get; set; }
        public string Title { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
