
using PublishData1;

using (PubContext context = new PubContext())
{
    context.Database.EnsureCreated();
}

GetAuthors();
void GetAuthors()
{
    using var context = new PubContext();

    var authors = context.Authors.ToList();

    foreach (var auth in authors)
    {
        Console.WriteLine(auth.FirstName +" "+ auth.LastName);
    }
}