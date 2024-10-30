public class EternalGoal : Goal
{
    private int eventsRecorded;

    public EternalGoal(string name, int points) : base(name, points)
    {
        eventsRecorded = 0;
    }

    public override void RecordEvent()
    {
        eventsRecorded++;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStatus()
    {
        return $"Completed {eventsRecorded} times";
    }
}