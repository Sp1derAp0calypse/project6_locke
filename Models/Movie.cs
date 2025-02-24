using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; } // Dropdown: G, PG, PG-13, R
        public bool? Edited { get; set; } // Nullable (Yes/No)
        public string? LentTo { get; set; } // Nullable
        public string? CopiedToPlex { get; set; } 
        public string? Notes { get; set; } // Nullable, Max 25 characters

    }
}