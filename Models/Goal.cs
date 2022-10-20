namespace WolffGoals.Models;

public class Goal 
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public bool IsComplete { get; set; }
    public DateTime DateCreated { get; set; }
}