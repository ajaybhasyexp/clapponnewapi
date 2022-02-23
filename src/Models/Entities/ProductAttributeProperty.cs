using System;
using System.Collections.Generic;
namespace Models.Entities
{
    public class ProductAttributeProperty
    {
        public int ProductAttributePropertyId { get; set; }
        public int ProductAttributeId { get; set; }
        public int ProductPropertyId { get; set; }
        public string PropertyValue { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime Timestamp { get; set; }   
       
    }
}