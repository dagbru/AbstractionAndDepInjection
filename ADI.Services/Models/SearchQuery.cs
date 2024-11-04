namespace ADI.Services.Models;

public class SearchQuery
{
    public string Author { get; set; }
    public string Title { get; set; }
    public string Id { get; set; }
    public int? Limit { get; set; }
}