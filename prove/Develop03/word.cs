public class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public string GetDisplayText()
    {
        return IsHidden ? "[hidden]" : Text;
    }
}
