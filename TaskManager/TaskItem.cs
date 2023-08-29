public class TaskItem
{
    public int Id {get; set;}
    public string? Title { get; set; }
    public DateOnly date {get; set;}
    public bool IsDone { get; set; }
}