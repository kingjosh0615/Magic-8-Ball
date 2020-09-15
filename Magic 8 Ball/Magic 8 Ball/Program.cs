using System;
using System.Diagnostics;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            //string target = "http://www.mommytimes.net";
            while (x == 1)
            {
                Random rand1 = new Random();
                Console.ForegroundColor = (ConsoleColor)rand1.Next(15);
                Console.WriteLine("Enter your question");
                string question = Console.ReadLine();
                if (question == "Are you real?")
                { 
                }
                else if (question == "I hate you.")
                { 
                    while (y == 1)
                    {
                        Console.WriteLine("EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
                        //Process.Start("C:\Users\WILES_JOSHUA\Pictures\candont.jpg");
                        using (var proc = Process.Start(@"cmd.exe ", @"/c C:\Users\WILES_JOSHUA\Pictures\Pravin_Raut-min.jpg")) { }
                        //Process photoViewer = new Process();
                        //photoViewer.StartInfo.FileName = @"The photo viewer file path";
                        //photoViewer.StartInfo.Arguments = @"Your image file path";
                        //photoViewer.Start();
                        //C: \Users\WILES_JOSHUA\Desktop
                    }
                }
                else if (question == "Red Robin")
                {
                    Console.WriteLine("Yum");
                }
                else if (question == "Smitty is cool.")
                {
                    Console.WriteLine("No hes not.");
                }
                else
                {
                    
                }
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
    "The council will decide your fate.",
    "I'm not entirely sure.",
            };
                
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
