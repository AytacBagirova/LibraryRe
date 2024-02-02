namespace Services.Model.Response
{
    public class BookResponse
    {
        public string AuthorName{ get; set; }

        public string CategoryName { get; set; }

        public string LanguageName{ get; set; }

        public DateTime AdditionDate { get; set; }

        public string BookName { get; set; }

        public int Id { get; set; }
        public int AuthorId { get; set; } // Eksik olan özellik
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
    }
}
