namespace Assignment7;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        //Create the array for booking the seat 
        bool[] seats = new bool[10];

        //Starting availability of seats
        InitializeSeats(seats);

        DisplaySeatingArrangement(seats);

        //Get the user to choose the seat they want 
        Console.Write("Enter the seat number to book (1-10): ");
        int seatNumber = int.Parse(Console.ReadLine());

        //Ending availability of seats
        BookSeat(seats, seatNumber);

        DisplaySeatingArrangement(seats);

        Console.ReadKey();

    }

    //See if the seat is booked or available
    void InitializeSeats(bool[] seats)
    {
        Random random = new Random();

        for (int i = 0; i < seats.Length; i++)
        {
            seats[i] = random.Next(2) == 0; 
        }
    }

    void DisplaySeatingArrangement(bool[] seats)
    {
        Console.WriteLine("Current seating arrangement:");
        for (int i = 0; i < seats.Length; i++)
        {
            Console.WriteLine($"Seat {i + 1}: {(seats[i] ? "Available" : "Booked")}");
        }    
    }

    void BookSeat(bool[] seats, int seatNumber)
    {
        int index = seatNumber - 1;
        //Marks the seat number as booked(false) in the seats array
        //Gives a warning if the seat is already booked
        if (seats[index])
        {
            seats[index] = false; 
            Console.WriteLine($"Seat {seatNumber} has been successfully booked.");
        }
        else
        {
            Console.WriteLine($"Seat {seatNumber} is already booked. Please choose another seat.");
        }
    }
}

