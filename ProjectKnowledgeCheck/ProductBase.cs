using System;


namespace ProjectKnowledgeCheck
{
    public class ProductBase
    {
        
        public ProductBase()
        {
        }

        public decimal CurrentPrice { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int ProductQuantity { get; set; }
        
    }

}

