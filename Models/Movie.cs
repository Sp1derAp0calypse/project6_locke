namespace project6.Models
{
    public class Movie
    {
        public int MovieId { get; set; } // Primary Key
        public string Title { get; set; }
        public string Category { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; } // Dropdown: G, PG, PG-13, R
        public bool Edited { get; set; } // Nullable (Yes/No)
        public string? LentTo { get; set; } // Nullable
        public string? Notes { get; set; } // Nullable, Max 25 characters
    }
}