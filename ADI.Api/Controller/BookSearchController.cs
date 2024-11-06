using ADI.Services;
using ADI.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADI.Api.Controller;

[ApiController]
[Route("[controller]")]
public class BookSearchController : ControllerBase
{
    private readonly ILibraryApiClient _libraryApiClient;


    private readonly IConfiguration _configuration;

    public BookSearchController(ILibraryApiClient libraryApiClient)
    {
        _libraryApiClient = libraryApiClient;
    }
        
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookSearchDto>>> Search([FromQuery] string? author, [FromQuery] string? title, [FromQuery] string? id)
    {
        var searchQuery = new SearchQuery
        {
            Author = author,
            Title = title,
            Id = id
        };

        return Ok(await _libraryApiClient.Search(searchQuery));
    }
}