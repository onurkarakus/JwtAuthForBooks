using JwtAuthForBooks.Models;

namespace JwtAuthForBooks.Interfaces;

public interface IBookService
{
    public Task<List<BookTitle>> GetBookTitlesAsync();
    public Task<BookInformation> GetBookInformationByIdAsync(GetBookInformationByIdRequest request);
}
