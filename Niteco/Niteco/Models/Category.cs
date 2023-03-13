﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Niteco.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
