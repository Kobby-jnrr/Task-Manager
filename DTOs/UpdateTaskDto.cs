using TaskManager.Models;

namespace TaskManager.DTOs
{
    public class UpdateTaskDto
    {
        public  string? Title { get; set; }
        public  string? Description { get; set; }
        public TaskState? Status { get; set; }
    }
}
