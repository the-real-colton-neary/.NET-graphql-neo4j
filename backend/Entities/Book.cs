namespace backend.Entities
{
    public class Book
    {
        public string? Title { get; set; } = default!;

        public Author? Author { get; set; } = default!;
    }
}