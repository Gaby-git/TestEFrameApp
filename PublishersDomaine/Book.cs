
namespace PublisherDomail
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateOnly PublishedDate { get; set; }
        public decimal BasePice { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }

    }
}
