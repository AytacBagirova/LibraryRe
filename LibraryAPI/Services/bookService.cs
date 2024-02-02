using Grpc.Core;
using Library;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryAPI.Services
{
    public class BookService : Book.BookBase
    {
        private readonly HttpClient _httpClient;
        private const string GoogleBooksApiUrl = "https://www.googleapis.com/books/v1/volumes";


        private const string GoogleBooksApiKey = "AIzaSyCl3CvyzufqvpDKbjuI8T7F3bijc9MA7cw";

        public BookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public override async Task<BookResponse> GetBookInfo(BookRequest request, ServerCallContext context)
        {
            var bookQuery = request.BookQuery;


            var apiUrl = $"{GoogleBooksApiUrl}?q={bookQuery}&key={GoogleBooksApiKey}";

            using (var response = await _httpClient.GetAsync(apiUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var googleBooksResponse = JsonConvert.DeserializeObject<GoogleBooksResponse>(content);

                    if (googleBooksResponse != null && googleBooksResponse.Items != null && googleBooksResponse.Items.Count > 0)
                    {
                        var randomBookIndex = new Random().Next(googleBooksResponse.Items.Count);
                        var randomBook = googleBooksResponse.Items[randomBookIndex];

                        var bookResponse = new BookResponse
                        {
                            Title = randomBook.VolumeInfo.Title,
                            Author = randomBook.VolumeInfo.Authors != null ? string.Join(", ", randomBook.VolumeInfo.Authors) : "Yazar bilgisi yok",
                        };

                        return bookResponse;
                    }
                }
            }

            // Hata yönetimi
            return new BookResponse
            {
                Title = "Bilgi bulunamadý",
                Author = "Bilgi bulunamadý",
            };
        }
    }
}
