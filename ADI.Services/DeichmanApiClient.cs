using ADI.Services.Extensions;
using ADI.Services.Models;
using ADI.Services.Models.External;

namespace ADI.Services;

public class DeichmanApiClient : LibraryApiClientBase<DeichmanLibrarySearchDto>
{
    private const string ApiName = "Deichman";

    protected override string ApiUrl()
    {
        return "https://deichman.no/api/search";
    }

    protected override Dictionary<string, string> CreateQueries(SearchQuery searchQuery)
    {
        var queries = new Dictionary<string, string>();
        var searchWords = new List<string>();

        if (!string.IsNullOrEmpty(searchQuery.Author))
        {
            searchWords.AddRange(searchQuery.Author.Split(" "));
        }

        if (!string.IsNullOrEmpty(searchQuery.Title))
        {
            searchWords.AddRange(searchQuery.Title.Split(" "));
        }

        queries.Add("query", string.Join(" ", searchWords));
        queries.Add("filter", "mediaType_Bok");

        return queries;
    }

    protected override IEnumerable<BookSearchDto> Map(DeichmanLibrarySearchDto searchResults)
    {
        var bookResults = new List<BookSearchDto>();

        foreach (var book in searchResults.hits)
        {
            var bookSearchDto = new BookSearchDto
            {
                Author = book.work?.mainEntry,
                Title = book.mainTitle,
                Isbns = book.ids,
                AuthorId = book.work?.agentsInfo?.authors?.FirstOrDefault()?.id,
                Publishers = book.publishedBy,
                Subjects = book.work?.genres,
                BookId = book.id,
                TotalPages = book.numberOfPagesCosmetic,
                FirstPublishedYear = book.publicationYear,
                Language = book.languages?.FirstOrDefault(),
                ApiUsed = ApiName
            };

            var bookSeriesInfos = new List<BookSeriesInfo>();
            if (book.workSeriesInfo != null && book.workSeriesInfo.Length != 0)
            {
                bookSeriesInfos.AddRange(book.workSeriesInfo.Select((t, i) => new BookSeriesInfo
                {
                    Id = t.id,
                    Name = book.displaySeries[i].label,
                    Number = t.number,
                }));

                bookSearchDto.SeriesInfo = bookSeriesInfos;
            }

            bookResults.Add(bookSearchDto);
        }

        return bookResults;
    }
}