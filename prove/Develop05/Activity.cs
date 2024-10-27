public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Welcome to {name}. {description}");
        Console.Write("Enter duration in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public virtual void End()
    {
        Console.WriteLine("You have done a great job!");
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.WriteLine($"Activity: {name}, Duration: {duration} seconds");
    }
}