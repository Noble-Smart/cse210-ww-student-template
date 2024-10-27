public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Relax by focusing on your breathing.") { }

    public override void Start()
    {
        base.Start();
        for (int i = 0; i < duration; i += 5)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2500); // Pause for 2.5 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2500); // Pause for 2.5 seconds
        }
    }
}