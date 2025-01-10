namespace Assignment7;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //Create an object;
        Product product = new Product("Laptop", 1200);

        //Displaying the information
        Console.WriteLine($"Product Name: {product.Name}");
        Console.WriteLine($"Product Price: {product.Price}");

        Console.ReadKey();
    }
}

class Product
{
    //Properties with private setter for price
    public string Name { get; set; }
    public double Price { get; private set; }

    //Constructors to intialize
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

