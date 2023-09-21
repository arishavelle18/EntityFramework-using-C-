namespace EFCoreTutorial.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public ICollection<BookGenre> Genres { get; set;}

    }
}
