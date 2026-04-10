using System;

namespace CybersecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Play Voice Greeting
            var audio = new AudioPlayer("Greeting.wav"); // Make sure the file is in project folder
            audio.Play();

            // 2. Get user info
            var user = new User();

            // 3. Initialize chatbot
            var bot = new Chatbot(user);

            // 4. Display ASCII Art
            bot.DisplayAsciiArt();

            // 5. Greet User
            bot.GreetUser();

            // 6. Start chat loop
            bot.Run();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nThank you for using the Cybersecurity Awareness Bot!");
            Console.ResetColor();
        }
    }
}
      