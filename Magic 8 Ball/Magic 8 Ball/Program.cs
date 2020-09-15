using System;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x == 1)
            {
                Console.WriteLine("Enter your question");
                string question = Console.ReadLine();
                string[] magicAnswers = {
    "YES!",
    "NO!",
    "I don't understand the question.",
    "Probably not.",
    "Possibly?",
    "Totally.",
    "Not possible.",
    "Try again.",
    "That's kinda a dumb question.",
    "( ͡° ͜ʖ ͡°)",
    "Nope.",
    "Nani?!",
    "Yes.",
    "Go eat a sandwich.",
    "You've had enough computer time.",
    "The counsel will decide your fate.",
    "I'm not entirely sure.",
            };
                Random rand1 = new Random();
                double randomAnswer = rand1.Next(1, 17);
                Console.WriteLine("The great magic 8 ball says: " + magicAnswers[Convert.ToInt32(Math.Floor(randomAnswer))]);
                Console.WriteLine("Do you wish to ask another question?  'Y' for Yes, 'N' for No.");
                string playAgain = Console.ReadLine().ToLower();
                switch (playAgain)
                {
                    case "y":
                        x = 1;
                        break;
                    case "n":
                        Console.WriteLine("Alright, Cya!");
                        x = 0;
                        break;
                }
            }
        }
    }
}
