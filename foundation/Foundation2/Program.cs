using System;
using System.Collections.Generic;

// Define a class for Address
public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    // Constructor
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    // Getters and Setters
    public string StreetAddress { get { return streetAddress; } set { streetAddress = value; } }
    public string City { get { return city; } set { city = value; } }
    public string StateProvince { get { return stateProvince; } set { stateProvince = value; } }
    public string Country { get { return country; } set { country = value; } }

    // Method to check if address is in the USA
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    // Method to return address as a string
    public override string ToString()
    {
        return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
    }
}

// Define a class for Customer
public class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Getters and Setters
    public string Name { get { return name; } set { name = value; } }
    public Address Address { get { return address; } set { address = value; } }

    // Method to check if customer lives in the USA
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }
}

// Define a class for Product
public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Getters and Setters
    public string Name { get { return name; } set { name = value; } }
    public string ProductId { get { return productId; } set { productId = value; } }
    public decimal Price { get { return price; } set { price = value; } }
    public int Quantity { get { return quantity; } set { quantity = value; } }

    // Method to calculate total cost of product
    public decimal CalculateTotalCost()
    {
        return price * quantity;
    }
}

// Define a class for Order
public class Order
{
    private List<Product> products;
    private Customer customer;
    private const decimal USA_SHIPPING_COST = 5;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35;

    // Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    // Method to add product to order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate total cost of order
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.CalculateTotalCost();
        }
        if (customer.LivesInUSA())
        {
            totalCost += USA_SHIPPING_COST;
        }
        else
        {
            totalCost += INTERNATIONAL_SHIPPING_COST;
        }
        return totalCost;
    }

    // Method to generate packing label
    public string GeneratePackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += $"{product.Name} ({product.ProductId})\n";
        }
        return label;
    }

    // Method to generate shipping label
    public string GenerateShippingLabel()
    {
        return customer.Name + "\n" + customer.Address.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create customers
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Othertown", "Ontario", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to orders
        order1.AddProduct(new Product("Product A", "A123", 10.99m, 1));
        order1.AddProduct(new Product("Product A", "A123", 10.99m, 2));
        order1.AddProduct(new Product("Product B", "B456", 5.99m, 3));

        order2.AddProduct(new Product("Product C", "C789", 7.99m, 1));
        order2.AddProduct(new Product("Product D", "D012", 12.99m, 2));

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        Console.WriteLine();
    }
}