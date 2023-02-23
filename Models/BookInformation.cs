namespace JwtAuthForBooks.Models;

/// <summary>
/// Book Information
/// </summary>
public class BookInformation
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

    /// <summary>Gets or sets the description.</summary>
    /// <value>The description.</value>
    public string Description { get; set; }

    /// <summary>Gets or sets the name of the author.</summary>
    /// <value>The name of the author.</value>
    public string AuthorName { get; set; }
}