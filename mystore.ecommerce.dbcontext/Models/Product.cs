// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace mystore.ecommerce.dbcontext.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Status { get; set; }
        public bool OutOfStock { get; set; }

        public virtual ProductCategory CategoryNavigation { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}