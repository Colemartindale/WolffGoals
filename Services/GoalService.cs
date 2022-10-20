using WolffGoals.Models;

namespace WolffGoals.Services;

public static class GoalService
{
    static List<Goal> Goals { get; } 

    static int nextId = 3;

    static GoalService()
    {
        Goals = new List<Goal>
        {
            new Goal { Id = 1, Content = "Master C# and .NET", IsComplete = false, DateCreated = DateTime.Now },
            new Goal { Id = 2, Content = "Mow the lawn", IsComplete = true, DateCreated = DateTime.Now },
        };
    }

    public static List<Goal> GetAll() => Goals;

    public static Goal? Get(int id) => Goals.FirstOrDefault(g => g.Id == id);

    public static void Add(Goal goal)
    {
        goal.Id = nextId++;
        goal.DateCreated = DateTime.Now;
        Goals.Add(goal);
    }

    public static void Delete(int id)
    {
        var goal = Get(id);
        if(goal is null)
            return;
        
        Goals.Remove(goal);
    }

    public static void Update(Goal goal)
    {
        var index = Goals.FindIndex(g => g.Id == goal.Id);
        if(index == -1)
            return;

        Goals[index] = goal;
    }
}