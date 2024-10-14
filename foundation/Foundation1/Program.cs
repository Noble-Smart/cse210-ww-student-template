using System;
using System.Collections.Generic;

// Define a class for Comment
public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    // Override ToString method for easy display
    public override string ToString()
    {
        return $"{Name}: {Text}";
    }
}

// Define a class for Video
public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Override ToString method for easy display
    public override string ToString()
    {
        return $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nNumber of Comments: {GetCommentCount()}\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Python Tutorial", "John Doe", 300);
        Video video2 = new Video("C# Tutorial", "Jane Doe", 240);
        Video video3 = new Video("JavaScript Tutorial", "Bob Smith", 360);

        // Add comments to videos
        video1.AddComment(new Comment("Alice Johnson", "Great video!"));
        video1.AddComment(new Comment("Mike Brown", "Very informative."));
        video1.AddComment(new Comment("Emily Chen", "Love the examples."));

        video2.AddComment(new Comment("David Lee", "Excellent tutorial."));
        video2.AddComment(new Comment("Sarah Taylor", "Well explained."));
        video2.AddComment(new Comment("Kevin White", "Helpful!"));

        video3.AddComment(new Comment("Olivia Martin", " Fantastic video!"));
        video3.AddComment(new Comment("William Davis", "Very clear."));
        video3.AddComment(new Comment("Ava Garcia", "Great job!"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information and comments
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            foreach (var comment in video.Comments)
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}