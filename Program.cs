namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var randomNumber = rand.Next(0, 100);
            int guessedNumber = 101;
                Console.WriteLine("I am thinking of a number between 0 and 100. Guess it!");

            while (guessedNumber != randomNumber)
            {
                guessedNumber = Convert.ToInt32(Console.ReadLine());
                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("Correct! You guessed the number!");
                }
                else if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Too low, try again!");
                }
                else if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("Too high, try again!");
                }

            }
        }

    }
}