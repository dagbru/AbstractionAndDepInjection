using ADI.Services.Models;

namespace ADI.Services;

public interface ILibraryApiClient
{
    Task<IEnumerable<BookSearchDto>> Search(SearchQuery searchQuery);
}