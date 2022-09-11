using System.ComponentModel.DataAnnotations;

namespace TravelBuddyApi.Model
{
    public class TodoItem

    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        public decimal Duration { get; set; }

        public bool IsDone { get; set; }
    }
}
