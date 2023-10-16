using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практична_5
{
    internal class Order
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }
        public interface ISearchable
        {
            List<Product> SearchByPriceRange(double minPrice, double maxPrice);
            List<Product> SearchByCategory(string category);
            List<Product> SearchByRating(int rating);
        }
    }
}
