namespace Assignment6;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //create an arrray that store 6 values
        int[] diceCounts = new int [6];

        //Intialize all elements in this array with value 0.
        ThrowDice(diceCounts, 6000);

        for (int i = 0; i < diceCounts.Length; i++)
        {
            Console.WriteLine($"Number of throws of value {i + 1}: {diceCounts[i]}");
        }

        Console.ReadKey();
    }

    //Generate the number of throws 
    void ThrowDice(int[] diceCounts, int numberOfThrows)
    {
        Random random = new Random();

        for( int i = 0; i < numberOfThrows; i++ )
        {
            int diceValue = random.Next(1, 7);

            diceCounts [diceValue - 1]++;

        }

    }
}

