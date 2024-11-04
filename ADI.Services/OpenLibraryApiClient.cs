using ADI.Services.Extensions;
using ADI.Services.Models;
using ADI.Services.Models.External;

namespace ADI.Services;

public class OpenLibraryApiClient
{
    private const string ApiUrl = "https://openlibrary.org/search.json";
    private const string ApiName = "OpenLibrary";
    private const int DefaultLimit = 10;
    private static readonly string[] Fields =
    [
        "author_name",
        "isbn",
        "publisher",
        "title",
        "subject", 
        "publish_year", 
        "number_of_pages_median", 
        "author_key",
        "edition_key"
    ];
    
    public async Task<IEnumerable<BookSearchDto>> Search(SearchQuery searchQuery)
    {
        var urlBuilder = new UriBuilder(ApiUrl)
        {
            Query = await CreateQueryUrl(searchQuery)
        };
        
        using var httpClient = new HttpClient();
        var request = await httpClient.GetAsync(urlBuilder.ToString());
        
        request.EnsureSuccessStatusCode();
        
        var searchResults = (await request.Content.ReadAsStringAsync()).JsonDeserialize<OpenLibrarySearchDto>();

        return searchResults.docs.Select(x =>
            new BookSearchDto
            {
                Author = string.Join(", ", x.author_name == null ? new List<string>() : x.author_name),
                Isbns = x.isbn,
                Publishers = x.publisher,
                Title = x.title,
                Subjects = x.subject,
                FirstPublishedYear = x.publish_year?.Min() ?? default,
                TotalPages = x.number_of_pages_median,
                AuthorId = x.author_key?.FirstOrDefault(),
                BookId = x.edition_key?.FirstOrDefault(),
                ApiUsed = ApiName
            }
        );
    }

    private async Task<string> CreateQueryUrl(SearchQuery searchQuery)
    {
        var queries = new Dictionary<string, string>();

        if (!string.IsNullOrEmpty(searchQuery.Id))
        {
            queries.Add("q", searchQuery.Id);
        }
        else
        {
            if (!string.IsNullOrEmpty(searchQuery.Author))
            {
                queries.Add("author", searchQuery.Author);
            }

            if (!string.IsNullOrEmpty(searchQuery.Title))
            {
                queries.Add("title", searchQuery.Title);
            }
        }
        
        queries.Add("limit", searchQuery.Limit == null ? DefaultLimit.ToString() : searchQuery.Limit.Value.ToString());
        queries.Add("fields", string.Join(",", Fields));

        return await new FormUrlEncodedContent(queries)
            .ReadAsStringAsync();
    }

}