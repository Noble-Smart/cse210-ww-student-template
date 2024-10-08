// ScriptureLibrary.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ScriptureLibrary
{
    public List<Scripture> Scriptures { get; set; }

    public ScriptureLibrary(string filePath)
    {
        Scriptures = new List<Scripture>();
        LoadScripturesFromFile(filePath);
    }

    private void LoadScripturesFromFile(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        for (int i = 0; i < lines.Length; i += 2)
        {
            var reference = lines[i];
            var text = lines[i + 1];
            var parts = reference.Split(' ');
            var book = "";
            var chapterVerse = "";

            // Separate book name from chapter and verse
            foreach (var part in parts)
            {
                if (part.Contains(":"))
                {
                    chapterVerse = part;
                    break;
                }
                else
                {
                    book += part + " ";
                }
            }
            book = book.Trim();

            var chapterVerseParts = chapterVerse.Split(':');
            var chapter = int.Parse(chapterVerseParts[0]);
            var verseParts = chapterVerseParts[1].Split('-');
            var startVerse = int.Parse(verseParts[0]);
            var endVerse = verseParts.Length > 1 ? (int?)int.Parse(verseParts[1]) : (int?)null;
            var scriptReference = endVerse.HasValue
                ? new Reference(book, chapter, startVerse, chapter, endVerse.Value)
                : new Reference(book, chapter, startVerse);
            Scriptures.Add(new Scripture(scriptReference, text));
        }
    }

    public Scripture GetRandomScripture()
    {
        var random = new Random();
        return Scriptures.ElementAt(random.Next(Scriptures.Count));
    }
}