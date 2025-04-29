namespace LibraryApp.Models
{
    public class BookDTO
    {
        public required string Title { get; set; }

        public required string Author { get; set; }

        public required DateTime? ReleaseDate { get; set; }
    }
}
