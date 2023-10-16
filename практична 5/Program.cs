using System;
using System.Collections.Generic;
using практична_5;

class Program
{
    static void Main(string[] args)
    {
        // Створення магазину
        Store store = new Store();

        // Додавання користувачів і товарів
        User user1 = new User("user1", "password1");
        User user2 = new User("user2", "password2");
        store.AddUser(user1);
        store.AddUser(user2);

        Product product1 = new Product
        {
            Name = "Product 1",
            Price = 10.0,
            Description = "Description for Product 1",
            Category = "Category 1",
            Rating = 4
        };

        Product product2 = new Product
        {
            Name = "Product 2",
            Price = 15.0,
            Description = "Description for Product 2",
            Category = "Category 2",
            Rating = 5
        };

        store.AddProduct(product1);
        store.AddProduct(product2);

        // Робимо замовлення
        List<Product> productsToOrder = new List<Product> { product1, product2 };
        store.PlaceOrder(user1, productsToOrder, 2, "Замовлено");

        // Пошук товарів за критеріями
        List<Product> searchResult = store.SearchByCategory("Category 1");
        Console.WriteLine("Товари в категорії 'Category 1':");
        foreach (var product in searchResult)
        {
            Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price}, Рейтинг: {product.Rating}");
        }

        // Відображення історії покупок користувача
        Console.WriteLine("Історія покупок користувача:");
        foreach (var order in user1.PurchaseHistory)
        {
            Console.WriteLine($"Замовлення №{user1.PurchaseHistory.IndexOf(order) + 1}:");
            foreach (var product in order.Products)
            {
                Console.WriteLine($"Назва: {product.Name}, Кількість: {order.Quantity}, Загальна вартість: {order.TotalPrice}");
            }
        }
    }
}
