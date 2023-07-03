using MusicPlayer.Shared;
using System.Net.Http.Json;

namespace MusicPlayer.Client.Services.MusicServices
{
    public class MusicServices : IMusicServices
    {
        private readonly HttpClient _http;
        public MusicServices(HttpClient http)
        {
            _http = http;
        }
        public List<Musics> musics { get ; set ; } = new List<Musics>();
        public HttpClient Http { get; }

        public async Task GetMusic()
        {
            var result = await _http.GetFromJsonAsync<List<Musics>>("api/music");
            if (result != null) 
                musics = result;

        }
    }
}
