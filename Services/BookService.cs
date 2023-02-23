using JwtAuthForBooks.Interfaces;
using JwtAuthForBooks.Models;

namespace JwtAuthForBooks.Services;

/// <summary>
/// Book Service
/// </summary>
public class BookService : IBookService
{
    static readonly List<BookInformation> bookInformations = new List<BookInformation> {
            new BookInformation { BookId = 1, Isbn = "9752115047", Title ="22/11/63",  AuthorName = "Stephen King",  Description = "22 Kasım 1963’te, bütün bunları değiştirme şansınız olsaydı?" },
            new BookInformation { BookId = 2, Isbn = "1476762740", Title ="Uyuyan Güzeller",  AuthorName = "Stephen King *  Owen King",  Description = "Şimdi burada dünyanın kaderine karar verilecek." },
            new BookInformation { BookId = 3, Isbn = "9752126049", Title ="Enstitü",  AuthorName = "Stephen King",  Description = "Enstitü..." }
        };

    /// <summary>Gets the book information by identifier asynchronous.</summary>
    /// <param name="request">The request.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    public Task<BookInformation> GetBookInformationByIdAsync(GetBookInformationByIdRequest request)
    {
        var loadedBookInformation = bookInformations.FirstOrDefault(p => p.BookId == request.BookId);

        return Task.FromResult(loadedBookInformation);
    }

    /// <summary>Gets the book titles asynchronous.</summary>
    /// <returns>
    ///   <br />
    /// </returns>
    public Task<List<BookTitle>> GetBookTitlesAsync()
    {
        var booktitleList = bookInformations.Select(book => GenerateBookTitleForList(book)).ToList();

        return Task.FromResult(booktitleList);
    }

    /// <summary>Generates the book title for list.</summary>
    /// <param name="book">The book.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    private static BookTitle GenerateBookTitleForList(BookInformation book)
    {
        return new BookTitle { BookId = book.BookId, Title = book.Title, Isbn = book.Isbn };
    }
}
