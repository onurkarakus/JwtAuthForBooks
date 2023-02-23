namespace JwtAuthForBooks.Models;

/// <summary>
/// Get Book Information By Id Request
/// </summary>
public class GetBookInformationByIdRequest
{
    /// <summary>Gets or sets the book identifier.</summary>
    /// <value>The book identifier.</value>
    public int BookId { get; set; }
}
