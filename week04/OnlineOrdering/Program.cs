using System;

class Program
{
    static void Main(string[] args)
    {
        //Create 2 orders with 2-3 products each.
        Address address1 = new Address("2486 East Fisher Ln", "Salt Lake City", "Utah", "Country");
        
        Customer customer1 = new Customer("James Willcox", address1);

        Product product1 = new Product("Computer", 624051, 100.24, 1);
        Product product2 = new Product("Keyboard", 874592, 36.22, 1);
        List<Product> products = new List<Product> { product1, product2 };

        Order order1 = new Order(customer1, products);

        Address address2 = new Address("8534 Maul Oak Dr", "Toronto", "Ontario", "Canada");

        Customer customer2 = new Customer("Devon Peterson", address2);

        Product product3 = new Product("Mouse", 658924, 19.57, 1);
        Product product4 = new Product("Charging Cable", 874561, 20.18, 2);
        List<Product> products2 = new List<Product> { product3, product4 };

        Order order2 = new Order(customer2, products2);

        Console.WriteLine($"ORDER 1:\n{order1.GetPackingLabel()}\n{order1.GetShippingLabel()}\n${order1.GetTotalCost().ToString("F2")}\n");
        Console.WriteLine($"ORDER 2:\n{order2.GetPackingLabel()}\n{order2.GetShippingLabel()}\n{order2.GetTotalCost().ToString("F2")}\n");

    }
}