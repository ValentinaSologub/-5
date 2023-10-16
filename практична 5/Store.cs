using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практична_5
{
    internal class Store
    {
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public Store()
        {
            Users = new List<User>();
            Products = new List<Product>();
            Orders = new List<Order>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void PlaceOrder(User user, List<Product> products, int quantity, string status)
        {
            var order = new Order
            {
                Products = products,
                Quantity = quantity,
                Status = status
            };
            order.TotalPrice = products.Sum(p => p.Price * quantity);
            user.PurchaseHistory.Add(order);
            Orders.Add(order);
        }

        // Реалізація методів ISearchable
        public List<Product> SearchByPriceRange(double minPrice, double maxPrice)
        {
            return Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public List<Product> SearchByCategory(string category)
        {
            return Products.Where(p => p.Category == category).ToList();
        }

        public List<Product> SearchByRating(int rating)
        {
            return Products.Where(p => p.Rating == rating).ToList();
        }
    }
}
