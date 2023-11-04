using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyApi.Model
{
    [Table("principal")]
    public class Principal
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Password { get; set; }

        [DefaultValue(RoleType.Regular)]
        public RoleType RoleType { get; set; }

    }
}
