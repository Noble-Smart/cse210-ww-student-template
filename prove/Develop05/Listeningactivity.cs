public class ListingActivity : Activity
{
    private string[] prompts = { /* list of prompts */ };

    public ListingActivity() : base("Listing", "Reflect on the good things in your life.") { }

    public override void Start()
    {
        base.Start();
        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine("List as many items as you can:");
        List<string> items = new List<string>();
        for (int i = 0; i < duration / 10; i++)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
            Thread.Sleep(5000); // Pause for 5 seconds
        }
        Console.WriteLine($"You listed {items.Count} items.");
    }
}