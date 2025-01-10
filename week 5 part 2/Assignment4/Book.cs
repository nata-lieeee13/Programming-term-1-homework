using System;
namespace Assignment4
{
	public class Book
	{
		//Create the two fields
		public string Title { get; set; }
		public string Author { get; set; }

		public Book(string title, string author)
		{
			Title = title;
			Author = author;
		}

        public void DisplayBookInfo()
		{
			Console.WriteLine($"Book Title: {Title}");
			Console.WriteLine($"Author: {Author}");
		}
	}
}