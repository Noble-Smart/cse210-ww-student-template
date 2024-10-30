public class ChecklistGoal : Goal
{
    private int eventsRecorded;
    private int targetCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        eventsRecorded = 0;
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        eventsRecorded++;
        if (eventsRecorded == targetCount)
        {
            // Award bonus points
        }
    }

    public override bool IsComplete()
    {
        return eventsRecorded >= targetCount;
    }

    public override string GetStatus()
    {
        return $"Completed {eventsRecorded}/{targetCount} times";
    }
}