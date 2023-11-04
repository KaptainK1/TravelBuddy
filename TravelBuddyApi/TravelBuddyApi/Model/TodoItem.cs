using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyApi.Model
{
    [Table("todo_item")]
    public class TodoItem

    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("title")]
        public required string Title { get; set; }

        [Required]
        [MaxLength(500)]
        [Column("description")]
        public required string Description { get; set; }

        [Column("duration")]
        public decimal Duration { get; set; }

        [Column("is_done")]
        public bool IsDone { get; set; }
    }
}
