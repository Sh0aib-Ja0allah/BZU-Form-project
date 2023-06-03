using System.ComponentModel.DataAnnotations;

namespace BZU_regestration_API.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Organization { get; set; }
        [Required]
        public string? Position { get; set; }
        [Required]
        public string? City { get; set; }
    }
}
