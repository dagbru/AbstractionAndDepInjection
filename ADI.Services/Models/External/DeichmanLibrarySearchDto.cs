namespace ADI.Services.Models.External;

public class DeichmanLibrarySearchDto
{
    public Filters[] filters { get; set; }
    public Hits[] hits { get; set; }
    public int totalHits { get; set; }
    public int numHitsRemoved { get; set; }
}

public class Filters
{
    public string type { get; set; }
    public Options[] options { get; set; }
}

public class Options
{
    public string text { get; set; }
    public string value { get; set; }
    public int count { get; set; }
}

public class Hits
{
    public string id { get; set; }
    public string uri { get; set; }
    public string recordId { get; set; }
    public string mediaType { get; set; }
    public string mainTitle { get; set; }
    public Agents agents { get; set; }
    public AgentsInfo agentsInfo { get; set; }
    public Work work { get; set; }
    public OtherPublications otherPublications { get; set; }
    public string created { get; set; }
    public bool deleted { get; set; }
    public string[] titleAll { get; set; }
    public int ageLimit { get; set; }
    public string coverImage { get; set; }
    public string[] various { get; set; }
    public string partTitle { get; set; }
    public int publicationYear { get; set; }
    public string[] ids { get; set; }
    public string[] languages { get; set; }
    public string[] locationClassNumber { get; set; }
    public string shelfMark { get; set; }
    public string fullTitle { get; set; }
    public string[] allAgents { get; set; }
    public string[] series { get; set; }
    public WorkSeriesInfo[] workSeriesInfo { get; set; }
    public DisplaySeries[] displaySeries { get; set; }
    public string[] publishedBy { get; set; }
    public int numberOfPagesCosmetic { get; set; }
    public string[] author { get; set; }
    public string[] homeBranches { get; set; }
    public string[] availableBranches { get; set; }
    public string[] locations { get; set; }
    public int numItems { get; set; }
    public object reservesByYear { get; set; }
    public object issuesByYear { get; set; }
    public int issuesTotal { get; set; }
    public int kohaPopularity { get; set; }
    public int likes { get; set; }
    public object[] likedBy { get; set; }
    public bool recommended { get; set; }
    public object recommendations { get; set; }
    public Images images { get; set; }
    public object[] flags { get; set; }
    public string partNumber { get; set; }
    public string[] hiddenSearchables { get; set; }
    public string subtitle { get; set; }
}

public class Agents
{
}

public class AgentsInfo
{
}

public class Work
{
    public string id { get; set; }
    public string uri { get; set; }
    public string mainTitle { get; set; }
    public string type { get; set; }
    public Agents1 agents { get; set; }
    public AgentsInfo1 agentsInfo { get; set; }
    public string[] fictionNonfiction { get; set; }
    public string mainEntry { get; set; }
    public string[] mainEntryNationalities { get; set; }
    public MainEntryInfo mainEntryInfo { get; set; }
    public int publicationYear { get; set; }
    public string[] literaryForms { get; set; }
    public string[] genres { get; set; }
    public string[] audiences { get; set; }
    public string[] languages { get; set; }
    public string[] subjects { get; set; }
}

public class Agents1
{
    public string[] authors { get; set; }
}

public class AgentsInfo1
{
    public Authors[] authors { get; set; }
}

public class Authors
{
    public string uri { get; set; }
    public string id { get; set; }
    public string type { get; set; }
    public string label { get; set; }
    public string slug { get; set; }
    public string number { get; set; }
}

public class MainEntryInfo
{
    public string uri { get; set; }
    public string id { get; set; }
    public string type { get; set; }
    public string label { get; set; }
    public string slug { get; set; }
    public string number { get; set; }
}

public class OtherPublications
{
}

public class WorkSeriesInfo
{
    public string uri { get; set; }
    public string id { get; set; }
    public string type { get; set; }
    public string label { get; set; }
    public string slug { get; set; }
    public string number { get; set; }
}

public class DisplaySeries
{
    public string num { get; set; }
    public string label { get; set; }
}

public class Images
{
    public string small { get; set; }
    public string medium { get; set; }
    public string large { get; set; }
    public string largest { get; set; }
    public bool hasAllSizes { get; set; }
    public bool useFallback { get; set; }
    public string fallbackColor { get; set; }
}