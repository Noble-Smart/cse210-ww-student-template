public class Reference
{
    public string Book { get; set; }
    public int StartChapter { get; set; }
    public int StartVerse { get; set; }
    public int? EndChapter { get; set; }
    public int? EndVerse { get; set; }

    public Reference(string book, int startChapter, int startVerse)
    {
        Book = book;
        StartChapter = startChapter;
        StartVerse = startVerse;
    }

    public Reference(string book, int startChapter, int startVerse, int endChapter, int endVerse)
    {
        Book = book;
        StartChapter = startChapter;
        StartVerse = startVerse;
        EndChapter = endChapter;
        EndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (EndChapter.HasValue)
        {
            return $"{Book} {StartChapter}:{StartVerse}-{EndChapter.Value}:{EndVerse.Value}";
        }
        else
        {
            return $"{Book} {StartChapter}:{StartVerse}";
        }
    }
}
