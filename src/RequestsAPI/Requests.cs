using AutoMapper;
using Quizzator.Quizzator.Dtos;
using System.Text.Json;

namespace RequestsAPI
{
    public class Requests
    {
        private HttpClient HttpClient { get; }
        private IMapper Mapper { get; }
        private string ServerUrl { get; }
        private string ResourceUrl { get; }
        private Uri Uri { get; }

        public Requests(HttpClient client, IMapper mapper, string serverUrl, string resourceUrl)
        {
            HttpClient = client;
            Mapper = mapper;
            ServerUrl = serverUrl;
            ResourceUrl = resourceUrl;
            Uri = new Uri(ServerUrl + ResourceUrl);
        }

        public async Task<IEnumerable<ThemeDtos>> GetAll()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, Uri);

            var response = await HttpClient.SendAsync(request);
            using var responseStream = await response.Content.ReadAsStreamAsync();
            var result = await JsonSerializer.DeserializeAsync<IEnumerable<ThemeDtos>>(responseStream);
            return Mapper.Map<IEnumerable<ThemeDtos>>(result);
        }
    }
}