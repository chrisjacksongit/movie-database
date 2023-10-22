// Program name: MovieDatabase.cs
// Allows users to input the genre of a movie, save it, and store it.

using System;
using System.Linq;

public class Movie_Database
{
    public static void Main(string[] args)
    {
        Console.WriteLine("[Movie Database]");
        Console.WriteLine("\nWelcome to the Movie Database! Please select from the menu below:");

        Console.WriteLine("1) Save a movie");
        Console.WriteLine("2) Quit");

        Console.Write("\nWhat is your selection? - "); // Where the user inputs their selection from the menu
        int selection = Convert.ToInt32(Console.ReadLine());


        switch(selection)
        {
            case 1:
                Console.WriteLine("\nYou have chosen to save a movie.");
                Console.Write("What genre is your movie? - ");
                string genre = Console.ReadLine(); // Allows user to input the genre

                Console.Write("What is the title of your movie? - ");
                string title = Console.ReadLine(); // Allows user to input the title

                Console.WriteLine("\nYour movie, " + title + ", has been saved. The genre is " + genre + "."); // Reads out the input
                Console.Write("Would you like to do anything else? (Y/N) - "); 
                string option = Console.ReadLine();

                if (option == "Y")
                {
                    Console.Write("\nWhat is your selection? - ");
                    selection = Convert.ToInt32(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine("\nThank you for visitng the Movie Database! Goodbye!");
                }
                break;
            

            case 2:
                Console.WriteLine("\nThank you for visiting the Movie Database! Goodbye!");
                break;
        }

        if (selection <= 0 || selection > 3)
        {
            Console.WriteLine("\nInvalid input. Please try again."); // Returns error if the user inputs the wrong number
        }

        
    }
}