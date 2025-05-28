using System;
using System.ComponentModel.DataAnnotations;

namespace DentistryWeb.Models
{
    public class Patient
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required] public string Name { get; set; } = string.Empty;
        [Required] public string Gender { get; set; } = string.Empty;
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public string Career { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        [Required] public string Address { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
