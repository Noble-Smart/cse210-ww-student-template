public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        isComplete = false;
    }

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetStatus()
    {
        return isComplete ? "[X]" : "[ ]";
    }
}