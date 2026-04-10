using System;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public class Chatbot
    {
        private User _user;

        public Chatbot(User user)
        {
            _user = user;
        }

        public void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("        [ASCII Shield/Lock Logo]");
            Console.WriteLine("=======================================");
            Console.ResetColor();

            Console.WriteLine(@"
              _______
             /       \
            |  LOCK   |
             \_______/
            ");
        }

        public void GreetUser()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect($"\nHello {_user.Name}! Welcome to the Cybersecurity Awareness Bot.");
            TypeEffect("I’m here to help you stay safe online.");
            Console.ResetColor();
        }

        private void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }

        public void Run()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nAsk me a question (or type 'exit' to quit): ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please ask a valid question.");
                    continue;
                }

                if (input == "exit") break;

                string response = GetResponse(input);
                TypeEffect(response);
            }
        }

        private string GetResponse(string input)
        {
            if (input.Contains("how are you")) return "I’m a bot, but I’m functioning perfectly!";
            if (input.Contains("purpose")) return "I’m here to raise cybersecurity awareness and help you stay safe online.";
            if (input.Contains("password")) return "Tip: Always use strong, unique passwords and consider a password manager.";
            if (input.Contains("phishing")) return "Be careful with emails asking for personal info. Verify the sender before clicking links.";
            if (input.Contains("malware")) return "Keep your antivirus up to date and avoid downloading suspicious files.";
            if (input == "help") return "Try asking about: passwords, phishing, malware, VPN, scams, or 2FA.";
            return "I’m not sure about that. Try asking another cybersecurity question!";
        }
    }
}