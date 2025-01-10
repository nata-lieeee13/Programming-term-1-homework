using System;
namespace Assignment6
{
	public class VotingSystem
	{
			private VoteOption[] votes;
			private int currentVoteIndex;

			//creating constructors
			public VotingSystem(int size)
			{
				votes = new VoteOption[size];
				currentVoteIndex = 0;
			}

			//Method to cast votes
			public void CastVote(VoteOption vote)
			{
				if (currentVoteIndex < votes.Length)
				{
					votes[currentVoteIndex] = vote;
					currentVoteIndex++;
				}

				else
				{
				Console.WriteLine("No more votes can be cast");
				}
			}

			//Method to display the results
			public void DisplayResults()
			{
				int yesCount = 0;
				int noCount = 0;

				foreach (var vote in votes)
				{
				if (vote == VoteOption.Yes)
					yesCount++;
				else if (vote == VoteOption.No)
					noCount++;
				}

			Console.WriteLine($"Results:");
			Console.WriteLine($"Yes:{yesCount}");
			Console.WriteLine($"No: {noCount}");

		    }
		
	}
}

