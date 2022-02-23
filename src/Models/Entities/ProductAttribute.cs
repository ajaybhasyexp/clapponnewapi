using System;
using System.Collections.Generic;
namespace Models.Entities
{
    public class ProductAttribute
    {
        public int ProductAttributeId { get; set; }
        public int ProductId { get; set; }
        public string ProductAttributeName { get; set; }
        public decimal Mrp  { get; set; }
        public decimal Rate  { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime Timestamp { get; set; }

        public List<ProductAttributeProperty> ProductAttributeProperty { get; set; } = new List<ProductAttributeProperty>();
        
    }
}