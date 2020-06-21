using System.Collections.Generic;

namespace BethanyPieShopMobile.Shared.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Pie> Pies { get; set; }
    }
}