class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness App");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.Write("Choose an activity: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Activity activity;
        switch (choice)
        {
            case 1:
                activity = new BreathingActivity();
                break;
            case 2:
                activity = new ReflectionActivity();
                break;
            case 3:
                activity = new ListingActivity();
                break;
            default:
                return;
        }
        activity.Start();
        activity.End();
    }
}