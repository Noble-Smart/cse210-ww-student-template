 // Exceeding requirements:
        // 1. Added logging functionality to track activity sessions (LogActivityStart and LogActivityEnd methods)
        // 2. Implemented random prompt/question selection without duplicates in ReflectionActivity
        // 3. Enhanced animations using ASCII art in BreathingActivity
        // 4. Added a fourth activity, GratitudeActivity, to help users focus on positivity
        // 5. Saved activity logs to a file (LogActivity method)
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
