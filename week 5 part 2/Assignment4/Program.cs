namespace Assignment4;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //User input on the book and author 
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter book author: ");
        string author = Console.ReadLine();

        //Create instance for book 
        Book book = new Book(title, author);

        //Display book information
        Console.WriteLine("Book information:");
        book.DisplayBookInfo();

        Console.ReadKey();
    }
}

