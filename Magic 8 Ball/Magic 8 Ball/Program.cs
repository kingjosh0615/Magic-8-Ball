using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            
            while (x == 1)
            {
                Random rand1 = new Random();
                int numberOfSecondsToSleep = rand1.Next(1, 6);
                Console.ForegroundColor = (ConsoleColor)rand1.Next(15);
                Console.WriteLine("Enter your question");
                string question = Console.ReadLine();
                Console.WriteLine("Hmmm... let me think...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);

                if (question == "Are you real?")
                {
                    OpenBrowser("https://pointerpointer.com/");
                }
                else if (question == "I hate you.")
                {
                    while (y == 1)
                    {
                        Console.WriteLine("EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");

                        using var proc = Process.Start(@"cmd.exe ", @"/c C:\Users\WILES_JOSHUA\Pictures\Pravin_Raut-min.jpg");
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
                }
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

            static void OpenBrowser(string url)
            {
                try
                {
                    Process.Start(url);
                }
                catch
                {
                    // hack because of this: https://github.com/dotnet/corefx/issues/10361
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        url = url.Replace("&", "^&");
                        Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        Process.Start("xdg-open", url);
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        Process.Start("open", url);
                    }
                    else
                    {
                        throw;
                    }
                }
            }

        }
    }
}
