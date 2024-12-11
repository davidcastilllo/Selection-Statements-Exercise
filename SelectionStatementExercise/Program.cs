namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 45;

            // Console.WriteLine("Guess my favorite number");
            // int userInput = int.Parse(Console.ReadLine());

            // if (userInput < favNumber) {
            //  Console.WriteLine("Too low");
            // }
            // else if (userInput > favNumber) {
            //  Console.WriteLine("Too high");
            // }
            // else {
            //  Console.WriteLine("You got it right!");
            // }

            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower()) {
             case "math":
             Console.WriteLine("Math is cool!");
             break;
             case "science":
             Console.WriteLine("Science is cool!");
             break;
             case "history":
             Console.WriteLine("History is cool!");
             break;
             case "geography":
             Console.WriteLine("Geography is cool!");
             break;
             case "lunch":
             Console.WriteLine("Lunch is my favorite!");
             break;
             default:
             Console.WriteLine("Thats not a subject on my list!");
             break;
            }
        }
    }
}
