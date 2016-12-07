using System.Collections.Generic;

namespace SimplyBitsTest.Models
{
    public class Item
    {
        public string PKID { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbUrl { get; set; }
        public string DisplayGroupID { get; set; }
        public string Price { get; set; }
        public string TaxExempt { get; set; }
        public string ColorR { get; set; }
        public string ColorG { get; set; }
        public string ColorB { get; set; }
        public string colorR { get; set; }
        public string colorG { get; set; }
        public string colorB { get; set; }
        public string SizeColorR { get; set; }
        public string SizeColorG { get; set; }
        public string SizeColorB { get; set; }
        public string MiscCharge { get; set; }
        public string Gift { get; set; }
        public string NonRevenue { get; set; }
        public string PreventDiscounts { get; set; }
        public string HideOnReceipt { get; set; }
        public string Precourse { get; set; }
        public string SKU { get; set; }
        public string Weighted { get; set; }
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<object> tags { get; set; }
        public List<object> attributes { get; set; }
        public List<object> sizes { get; set; }
        public List<object> modifiers { get; set; }
    }

}