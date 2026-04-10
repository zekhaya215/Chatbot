using System;
using System.Media; // Built-in SoundPlayer

namespace CybersecurityAwarenessBot
{
    public class AudioPlayer
    {
        private string _filePath;

        public AudioPlayer(string filePath)
        {
            _filePath = filePath;
        }

        public void Play()
        {
            try
            {
                // Use built-in SoundPlayer, not your custom one
                AudioPlayer player = new AudioPlayer(_filePath);
                player.Load();      // Load WAV file
                player.PlaySync();  // Play it synchronously
            }
            catch (Exception ex)
            {
                Console.WriteLine("Voice greeting could not be played: " + ex.Message);
            }
        }

        private void Load()
        {
            throw new NotImplementedException();
        }
        // Placeholder method for playing audio synchronously
        // (Not yet implemented - will cause error if called)
        private void PlaySync()
        {
            throw new NotImplementedException();
        }
    }
}