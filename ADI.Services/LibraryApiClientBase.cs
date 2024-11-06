using ADI.Services.Extensions;
using ADI.Services.Models;

namespace ADI.Services;

public abstract class LibraryApiClientBase<T> : ILibraryApiClient
{
    protected abstract string ApiUrl();
    protected abstract Dictionary<string, string> CreateQueries(SearchQuery searchQuery);
    protected abstract IEnumerable<BookSearchDto> Map(T searchResults);
    
    public async Task<IEnumerable<BookSearchDto>> Search(SearchQuery searchQuery)
    {
        var urlBuilder = new UriBuilder(ApiUrl())
        {
            Query = await CreateQueryUrl(searchQuery)
        };
        
        using var httpClient = new HttpClient();
        var request = await httpClient.GetAsync(urlBuilder.ToString());
        
        request.EnsureSuccessStatusCode();
        
        var searchResults = (await request.Content.ReadAsStringAsync()).JsonDeserialize<T>();

        return Map(searchResults);
    }

    private async Task<string> CreateQueryUrl(SearchQuery searchQuery)
    {
        return await new FormUrlEncodedContent(CreateQueries(searchQuery))
            .ReadAsStringAsync();
    }
}