namespace JwtAuthForBooks.Models;

/// <summary>
/// Book Title
/// </summary>
public class BookTitle
{
    /// <summary>Gets or sets the book identifier.</summary>
    /// <value>The book identifier.</value>
    public int BookId { get; set; }

    /// <summary>Gets or sets the isbn.</summary>
    /// <value>The isbn.</value>
    public string Isbn { get; set; }

    /// <summary>Gets or sets the title.</summary>
    /// <value>The title.</value>
    public string Title { get; set; }
}
