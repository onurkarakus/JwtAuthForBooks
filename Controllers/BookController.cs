using JwtAuthForBooks.Interfaces;
using JwtAuthForBooks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthForBooks.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    readonly IBookService bookService;

	public BookController(IBookService bookService)
	{
		this.bookService = bookService;
	}

    [HttpPost("GetBookTitles")]
    [AllowAnonymous]
    public async Task<ActionResult<List<BookTitle>>> GetBookTitles()
    {
        var result = await bookService.GetBookTitlesAsync();

        return result;
    }

    [HttpPost("GetBookInformationById")]
    [Authorize]
    public async Task<ActionResult<BookInformation>> GetBookInformationById([FromBody] GetBookInformationByIdRequest request)
    {
        var result = await bookService.GetBookInformationByIdAsync(request);

        return result;
    }
}
