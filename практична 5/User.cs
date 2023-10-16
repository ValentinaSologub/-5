using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace практична_5
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Order> PurchaseHistory { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            PurchaseHistory = new List<Order>();
        }
    }
}
