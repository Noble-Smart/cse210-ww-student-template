public class ReflectionActivity : Activity
{
    private string[] prompts = { /* list of prompts */ };
    private string[] questions = { /* list of questions */ };

    public ReflectionActivity() : base("Reflection", "Reflect on times of strength and resilience.") { }

    public override void Start()
    {
        base.Start();
        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        Thread.Sleep(3000); // Pause for 3 seconds
        for (int i = 0; i < duration / 10; i++)
        {
            int questionIndex = rand.Next(questions.Length);
            Console.WriteLine(questions[questionIndex]);
            Thread.Sleep(5000); // Pause for 5 seconds
        }
    }
}