using System;
using System.Collections.Generic;

#nullable disable

namespace Niteco.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Image { get; set; }
        public int? Price { get; set; }
        public int? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
