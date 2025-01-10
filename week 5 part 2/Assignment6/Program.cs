using System;
namespace Assignment6;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    //Enter the amount of votes to process
    void start()
    {
        Console.Write("How many votes should be processed: ");
        int numberOfVotes;
        while (!int.TryParse(Console.ReadLine(), out numberOfVotes) || numberOfVotes <= 0)
        {
            Console.WriteLine("Invalid");
        }

        VotingSystem votingSystem = new VotingSystem(numberOfVotes);

        //Get user to enter vote

        Console.WriteLine("Enter your votes (Yes/No):");

        for (int i = 0; i < numberOfVotes; i++)
        {
            Console.Write($"Vote {i+1}: ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out VoteOption vote))
            {
                votingSystem.CastVote(vote);
            }
            else
            {
                Console.WriteLine("Invalid");
                i--;
            }
        }

        votingSystem.DisplayResults();
        Console.ReadKey();
    }
}