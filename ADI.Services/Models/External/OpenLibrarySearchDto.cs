namespace ADI.Services.Models.External;

public class OpenLibrarySearchDto
{
    public int numFound { get; set; }
    public int start { get; set; }
    public bool numFoundExact { get; set; }
    public Docs[] docs { get; set; }
    public int num_found { get; set; }
    public string q { get; set; }
    public object offset { get; set; }
}

public class Docs
{
    public string[] author_alternative_name { get; set; }
    public string[] author_key { get; set; }
    public string[] author_name { get; set; }
    public string cover_edition_key { get; set; }
    public int cover_i { get; set; }
    public string[] ddc { get; set; }
    public string ebook_access { get; set; }
    public int ebook_count_i { get; set; }
    public int edition_count { get; set; }
    public string[] edition_key { get; set; }
    public int first_publish_year { get; set; }
    public string[] format { get; set; }
    public bool has_fulltext { get; set; }
    public string[] ia { get; set; }
    public string[] ia_collection { get; set; }
    public string ia_collection_s { get; set; }
    public string[] isbn { get; set; }
    public string key { get; set; }
    public string[] language { get; set; }
    public int last_modified_i { get; set; }
    public string[] lcc { get; set; }
    public string[] lccn { get; set; }
    public int number_of_pages_median { get; set; }
    public string[] oclc { get; set; }
    public string printdisabled_s { get; set; }
    public bool public_scan_b { get; set; }
    public string[] publish_date { get; set; }
    public string[] publish_place { get; set; }
    public int[] publish_year { get; set; }
    public string[] publisher { get; set; }
    public string[] seed { get; set; }
    public string title { get; set; }
    public string title_sort { get; set; }
    public string title_suggest { get; set; }
    public string type { get; set; }
    public string[] id_amazon { get; set; }
    public string[] id_goodreads { get; set; }
    public string[] id_librarything { get; set; }
    public string[] subject { get; set; }
    public double ratings_average { get; set; }
    public double ratings_sortable { get; set; }
    public int ratings_count { get; set; }
    public int ratings_count_1 { get; set; }
    public int ratings_count_2 { get; set; }
    public int ratings_count_3 { get; set; }
    public int ratings_count_4 { get; set; }
    public int ratings_count_5 { get; set; }
    public int readinglog_count { get; set; }
    public int want_to_read_count { get; set; }
    public int currently_reading_count { get; set; }
    public int already_read_count { get; set; }
    public string[] publisher_facet { get; set; }
    public string[] subject_facet { get; set; }
    public long _version_ { get; set; }
    public string lcc_sort { get; set; }
    public string[] author_facet { get; set; }
    public string[] subject_key { get; set; }
    public string ddc_sort { get; set; }
}