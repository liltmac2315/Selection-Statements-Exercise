namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number guessing game.

            //var r = new Random();
            //var favNumber = r.Next(1, 1000);
            //int userInput;
            //var counter = 0;

            //do
            //{ 
            //    Console.WriteLine("Pick a number from 1 - 1000");
            //    userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"(userInput) Is too low");
            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"(userInput) Is too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You guessed it!");
            //    }
            //        counter++;

            //    Console.WriteLine($"You have guessed (counter) times");

            //    } while (userInput != favNumber) ;

            // Switch-case section
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();
            switch (subject.ToLower)
            {
                case "math":
                    Console.WriteLine("Ilove math.");
                    break;
                case "science":
                    Console.WriteLine("I love science.");
                    break;
                case "pe":
                    Console.WriteLine("I love pe.");
                    break;
                case "history":
                    Console.WriteLine("History is the best.");
                    break;
                case "english":
                    Console.WriteLine("english is boring.");
                    break;
                    default: Console.WriteLine("I don't know that subject.");
                    break;
            }
            
        }
            
    }
        
}
