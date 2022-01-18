using System;

namespace GuessTheNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int answer = rand.Next(0, 100);
            int guess = -1;

            while(guess != answer)
            {
                Console.WriteLine("Guess the right number?");
                guess = int.Parse(Console.ReadLine());
                if(guess > answer)
                {
                    Console.WriteLine("Too high");
                } else if(guess < answer)
                {
                    Console.WriteLine("Too low");
                }

            }
            Console.WriteLine($"You guess the right answer:  {answer}");
            

         }
    }
}
