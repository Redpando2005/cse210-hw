class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Brody Cartwright", address1);
        Customer customer2 = new Customer("James Sunderland", address2);

        // Create products
        Product product1 = new Product("Keyboard", "P001", 70, 1);
        Product product2 = new Product("Mouse", "P002", 20, 2);
        Product product3 = new Product("Monitor", "P003", 150, 1);

        Product product4 = new Product("Pillow", "P004", 20, 1);
        Product product5 = new Product("Desk Lamp", "P005", 30, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}