using System;

namespace CybersecurityAwarenessBot
{
    public class User
    {
        public string Name { get; private set; }

        public User()
        {
            Console.Write("Please enter your name: ");
            Name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Name))
                Name = "Guest";
            Name = Console.ReadLine()?.Trim();
        }
    }
}