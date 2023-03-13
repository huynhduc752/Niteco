using Niteco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Niteco.ViewModel
{
    public class CommonViewModel
    {
        public List<Customer> Customer { get; set; }
        public List<Category> Category { get; set; }
        public List<Product> Product { get; set; }
    }
}
