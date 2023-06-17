using Newtonsoft.Json;

namespace APIBible.Data
{
    public class BibleAPIService
    {
        public const string BaseUrl = "https://www.abibliadigital.com.br/api/";
        private readonly HttpClient _httpClient;


        public BibleAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(BaseUrl);
        }

        public BibleModel[] GetBooks()
        {
            string GetBooksURL = BaseUrl + "books";
            var response = _httpClient.GetStringAsync(GetBooksURL).Result;
            return JsonConvert.DeserializeObject<BibleModel[]>(response);
        }
        public FindBooks GetChapter(string abbrev)
        {
            string GetBooksURL = BaseUrl + "books/" + abbrev;
            var response = _httpClient.GetStringAsync(GetBooksURL).Result;
            return JsonConvert.DeserializeObject<FindBooks>(response);
        }
        public Scripture GetScripture(string abbrev, string chapter)
        {
            string GetBooksURL = BaseUrl + "verses/acf/" + abbrev + "/" + chapter;
            var response = _httpClient.GetStringAsync(GetBooksURL).Result;
            return JsonConvert.DeserializeObject<Scripture>(response);
        }
    }
}
