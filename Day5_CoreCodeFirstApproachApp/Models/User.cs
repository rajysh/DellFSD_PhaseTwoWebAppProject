using System;
using System.ComponentModel.DataAnnotations;

namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Range(18, 50)]
        public string Age { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
        public string Country { get; set; }
    }
}
