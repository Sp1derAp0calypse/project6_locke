using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project6.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; } // Primary Key

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; } // Foreign Key
        public Categories CategoryName { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
        public int? Year { get; set; }

        public string? Director { get; set; }
        public string? Rating { get; set; } // Dropdown: G, PG, PG-13, R
        [Required(ErrorMessage = "Edited status is required.")]
        public bool Edited { get; set; } // Nullable (Yes/No)
        public string? LentTo { get; set; } // Nullable
        [Required(ErrorMessage = "CopiedToPlex is required.")]
        public string CopiedToPlex { get; set; }
        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; } // Nullable, Max 25 characters

    }
}