using System;
using System.Collections.Generic;

#nullable disable

namespace D7_CoreDBFirstRelApp.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? ProductAddedDate { get; set; }
        public int? BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
