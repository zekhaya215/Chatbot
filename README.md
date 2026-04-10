Cybersecurity Awareness Bot 

Project Overview
The Cybersecurity Awareness Bot is a C# console application designed to educate users about basic cybersecurity concepts. It interacts with users through a chatbot, provides safety tips, and includes a voice greeting feature.



 Purpose of the Project
The purpose of this project is to:
- Raise awareness about cybersecurity threats
- Teach users about safe online behavior
- Demonstrate OOP concepts in C#
- Create an interactive console-based chatbot


Features
 User name input and personalization
 Interactive chatbot responses
 Cybersecurity tips (passwords, phishing, malware, etc.)
 ASCII art display
 Voice greeting (WAV audio file)
 Typing animation effect for messages
 Continuous chat loop until user exits



Project Structure

 Program.cs
- Entry point of the application
- Starts audio greeting
- Initializes user and chatbot
- Runs the application flow

 Chatbot.cs
- Handles all chatbot logic
- Displays ASCII art
- Greets the user
- Processes user input
- Returns cybersecurity responses

User.cs
- Stores user name
- Takes input from console
- Defaults to "Guest" if no name is entered

 AudioPlayer.cs
- Intended to play a WAV audio greeting file
- Uses System.Media (SoundPlayer concept)



 Example Topics the Bot Can Answer
- Password security
- Phishing attacks
- Malware protection
- General cybersecurity awareness
- Help commands



How to Run the Project

1. Clone the repository:
bash
git clone https://github.com/your-username/your-repo-name.git
