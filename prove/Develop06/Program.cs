using System;
using System.Collections.Generic;

//          Exceeding Requirements:
// * Implemented leveling system with badges
// * Added progress tracking for large goals
// * Introduced negative goals with penalties

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create goals
        Goal simpleGoal = new SimpleGoal("Run a marathon", 1000);
        Goal eternalGoal = new EternalGoal("Read scriptures", 100);
        Goal checklistGoal = new ChecklistGoal("Attend temple", 50, 10, 500);

        // Create goal list
        List<Goal> goals = new List<Goal> { simpleGoal, eternalGoal, checklistGoal };

        // Display goal list
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetStatus()} {goal.Name} ({goal.Points} points)");
        }

        // Record events
        simpleGoal.RecordEvent();
        eternalGoal.RecordEvent();
        checklistGoal.RecordEvent();

        // Display updated goal list
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetStatus()} {goal.Name} ({goal.Points} points)");
        }

        // Save and load goals (implementation omitted)
    }
}