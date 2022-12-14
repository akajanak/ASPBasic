namespace BookApp.Data
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; internal set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int? TotalPages { get; set; }
        public DateTime? CreatedOn{ get; set; }
    }
}
