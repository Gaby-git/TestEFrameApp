
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using PublishData1;
using PublisherDomail;

using (PubContext context = new PubContext())
{
    context.Database.EnsureCreated();
}

GetAuthors();
AddAuthor();
GetAuthors();

void AddAuthor()
{
    var addAuthor = new List<Author>
    {
        new Author { FirstName = "Gabriel", LastName = "Lekane" },
        new Author { FirstName = "Jos", LastName = "Mile" },
        new Author { FirstName = "Goli", LastName = "Tafino" },
        new Author { FirstName = "Gibri", LastName = "raphaele" },
        new Author { FirstName = "jors", LastName = "bony" },
        new Author { FirstName = "gio", LastName = "tabou" },
        new Author { FirstName = "jordane", LastName = "Tsamo" },
        new Author { FirstName = "Mr.Nafack", LastName = "Etienne" },
    };

    using var context = new PubContext();

    context.Authors.AddRange(addAuthor);

    context.SaveChanges();

}
void GetAuthors()
{
    using var context = new PubContext();

    var authors = context.Authors.ToList();

    foreach (var auth in authors)
    {
        Console.WriteLine(auth.FirstName + " " + auth.LastName);
    }
}

AddAuthorWithBook();
GetAuthorsWithBooks();

void AddAuthorWithBook()
{
    var author = new Author { FirstName = "Test" , LastName = "Holio"};
    author.Books.Add(new Book { 
              Title = "ComeBackHome", PublishedDate = new DateOnly(2022, 1, 2) });
    author.Books.Add(new Book { 
              Title = "TomorrowAndToday", PublishedDate = new DateOnly(2012, 1, 7) });

    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthorsWithBooks()
{
    using var context = new PubContext();

    var authors = context.Authors.Include(a => a.Books).ToList();

    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
        foreach (var book in author.Books) 
        {
            Console.WriteLine(book.Title);
        };
    }
}
