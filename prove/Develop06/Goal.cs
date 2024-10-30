public abstract class Goal
{
    protected string name;
    protected int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public string Name { get { return name; } }
    public int Points { get { return points; } }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
}