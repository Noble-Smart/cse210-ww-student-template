using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Scripture.cs
public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var random = new Random();
        for (int i = 0; i < count; i++)
        {
            var index = random.Next(Words.Count);
            if (!Words[index].IsHidden)
            {
                Words[index].Hide();
            }
        }
    }

    public void Display()
    {
        Console.WriteLine(Reference.GetDisplayText());
        Console.WriteLine(string.Join(" ", Words.Select(w => w.GetDisplayText())));
    }
}