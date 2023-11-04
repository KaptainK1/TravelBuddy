﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBuddyApi.Model
{
    [Table("principal")]
    public class Principal
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("username")]
        public required string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("email")]
        public required string Email { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("password")]
        public required string Password { get; set; }

        [DefaultValue(RoleType.Regular)]
        [Column("role_type")]
        public RoleType RoleType { get; set; }

        //public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();

    }
}
