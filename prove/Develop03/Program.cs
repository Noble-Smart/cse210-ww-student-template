// Program.cs
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // EXCEEDING REQUIREMENTS:
        // Loaded scriptures from a file named 'scriptures.txt'.
        // Implemented a library of scriptures and select random ones to display.
        // Added feature to track user progress and provide statistics on memorization.

        var library = new ScriptureLibrary("scriptures.txt");
        var tracker = new MemorizationTracker();

        while (true)
        {
            var scripture = library.GetRandomScripture();
            while (true)
            {
                Console.Clear();
                scripture.Display();

                Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    return;
                }

                // Hide 5 random words
                scripture.HideRandomWords(5);

                // Check if all words are hidden
                if (scripture.Words.All(w => w.IsHidden))
                {
                    Console.Clear();
                    scripture.Display();
                    Console.WriteLine("All words are now hidden. Press Enter to continue.");
                    Console.ReadLine();
                    tracker.DisplayStatistics();
                    break;
                }
            }
        }
    }
}