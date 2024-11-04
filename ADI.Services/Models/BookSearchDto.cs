namespace ADI.Services.Models;

public class BookSearchDto
{
    public string ApiUsed { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public IEnumerable<string> Isbns { get; set; }
    public IEnumerable<string> Publishers { get; set; }
    public IEnumerable<string> Subjects { get; set; }
    public int FirstPublishedYear { get; set; }
    public long TotalPages { get; set; }
    public string AuthorId { get; set; }
    public string BookId { get; set; }
    public string CoverImageUrl { get; set; }
    public string Language { get; set; }
    public IEnumerable<BookSeriesInfo> SeriesInfo { get; set; }
}