namespace todo_backend;

public class TodoModel
{
    public int Index { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public TodoStatus Status { get; set; }
}