namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the super fun guessing game! Part one, my favorite number");

	    // For exercise one, we need to initialize a favorite number. I'm just going to use the fixed value
	    int favNumber = 42; // the answer to life, the universe, and everything. A solid choice

	    Console.WriteLine("Guess my favorite number:"); // This and the next line are from the assignment
	    int userInput = int.Parse(Console.ReadLine()); // I like this way to have the input automatically turned into an int

	    if (userInput < favNumber)  // Check to see if the guess is less than the favorite number
	    {
		    Console.WriteLine("Ooh, sorry. Too low."); // if too low, output that info to the user
            }
	    else if (userInput > favNumber) // Check if the guess is higher than the favorite number
	    {
		    Console.WriteLine("Whoops, sorry, that's too high."); // if yes, output that info to the user
	    }
            else // if it isn't too low, or too high, it must be correct
	    {
		    Console.WriteLine("You guessed it!!!"); // output that information to the user
	    }


	    // That wraps up exercise number one
	    //
	    // Below is exercise number two
	    //
	    // First, prompt the user for their favorite subject and store it in a variable
	    
	    Console.WriteLine("What is your favorite school subject?");
	    string favoriteSubject = Console.ReadLine();
	    
	    string f = favoriteSubject.ToLower(); // make the string lower case for error handling

	    // Next use a switch statement to respond to the user input. Five cases plus a default case
	    
	    switch (f)
	    {
		    case "math":
			Console.WriteLine("Math is cool because it's all about solving problems!");
		        break;

		    case "science":
			Console.WriteLine("Science helps us unlock the mysteries of the universe!");
		        break;

		    case "english":
			Console.WriteLine("As Ralph Wiggum famously said, 'me fail english? That's unpossible!'");
			break;

		    case "shop":
			Console.WriteLine("Oh yeah, everyone loves shop!");
			break;

		    case "home ec":
			Console.WriteLine("Home ec is great!");
			break;

		    default:
			Console.WriteLine("That's an interesting choice. What do you like about it?");
			break;

		}	







	    }




        }
    }
