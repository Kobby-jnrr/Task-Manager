using System.ComponentModel.DataAnnotations;
using TaskManager.Models;

namespace TaskManager.DTOs
{
    public class CreateTaskDto
    {
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Description { get; set; }
        public TaskState Status { get; set; } = TaskState.Pending;
    }
}