namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public TaskState Status { get; set; } = TaskState.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}