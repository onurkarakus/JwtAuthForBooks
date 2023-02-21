using JwtAuthForBooks.Interfaces;
using JwtAuthForBooks.Models;

namespace JwtAuthForBooks.Services;

public class BookService : IBookService
{
    readonly List<BookInformation> bookInformations;

    public BookService()
    {
        bookInformations = new List<BookInformation> {
            new BookInformation { BookId = 1, Isbn = "9752115047", Title ="22/11/63",  AuthorName = "Stephen King",  Description = "22 Kasım 1963’te, bütün bunları değiştirme şansınız olsaydı?" },
            new BookInformation { BookId = 2, Isbn = "1476762740", Title ="Uyuyan Güzeller",  AuthorName = "Stephen King *  Owen King",  Description = "Şimdi burada dünyanın kaderine karar verilecek." },
            new BookInformation { BookId = 3, Isbn = "9752126049", Title ="Enstitü",  AuthorName = "Stephen King",  Description = "Enstitü..." }
        };
    }

    public Task<BookInformation> GetBookInformationByIdAsync(GetBookInformationByIdRequest request)
    {
        var loadedBookInformation = bookInformations.FirstOrDefault(p => p.BookId == request.BookId);

        return Task.FromResult(loadedBookInformation);
    }

    public Task<List<BookTitle>> GetBookTitlesAsync()
    {
        var booktitleList = bookInformations.Select(book => GenerateBookTitleForList(book)).ToList();

        return Task.FromResult(booktitleList);
    }

    private static BookTitle GenerateBookTitleForList(BookInformation book)
    {
        return new BookTitle { BookId = book.BookId, Title = book.Title, Isbn = book.Isbn };
    }
}
