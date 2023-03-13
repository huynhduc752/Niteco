using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Niteco.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? CustomerId { get; set; }
        public int? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string OrderName { get; set; }
        public string CateTitle { get; set; }
        public int? OrderAmount { get; set; }
        public string ProductName { get; set; }
        public int? Price { get; set; }
    }
}
