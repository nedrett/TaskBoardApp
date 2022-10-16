namespace TaskBoardApp.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using static TaskBoardApp.Data.DataConstants.Board;

    public class Board
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxBoardName)]
        public string Name { get; set; }

        public IEnumerable<Task> Tasks { get; set; } = new List<Task>();
    }
}
