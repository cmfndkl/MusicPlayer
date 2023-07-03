using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicPlayer.Shared;

namespace MusicPlayer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        //static olarak tutulan veriler
        public static List<Musics> musics = new List<Musics>
        {
            new Musics{
                Id=1, 
                MusicName= "Geçmişin Yükü", 
                ArtistName= "Pentagram", 
                MusicUrl ="https://firebasestorage.googleapis.com/v0/b/musics-e3bba.appspot.com/o/Pentagram%20-%20Ge%C3%A7mi%C5%9Fin%20Y%C3%BCk%C3%BC%20(Akustik%20Alb%C3%BCm).mp3?alt=media&token=2a8fb49c-3831-42c1-beb5-aa8af78cb257"
            },
            new Musics{
                Id=2,
                MusicName = "Lost On You",
                ArtistName = "LP",
                MusicUrl = "https://firebasestorage.googleapis.com/v0/b/musics-e3bba.appspot.com/o/LP%20-%20Lost%20On%20You.mp3?alt=media&token=7c80a098-367e-44a0-9fc0-00a8fd7ff643"
            },
            new Musics{
                Id=3,
                MusicName = "Hotel California",
                ArtistName = "Eagles",
                MusicUrl = "https://firebasestorage.googleapis.com/v0/b/musics-e3bba.appspot.com/o/Eagles%20-%20Hotel%20California.mp3?alt=media&token=637f2bcc-b5f0-485d-b8e6-4580f55c26a5"
            },
            new Musics{
                Id=4,
                MusicName = "Burning Heat",
                ArtistName = "Survivor",
                MusicUrl = "https://firebasestorage.googleapis.com/v0/b/musics-e3bba.appspot.com/o/Survivor%20-%20Burning%20Heart.mp3?alt=media&token=fa3ced4b-0dd8-4156-b7e8-ec1efa8ea2f8"
            },
            new Musics{
                Id=5,
                MusicName = "Life is Life",
                ArtistName = "Opus",
                MusicUrl = "https://firebasestorage.googleapis.com/v0/b/musics-e3bba.appspot.com/o/Live%20is%20Life%20-%20Opus.mp3?alt=media&token=e0ffc871-3d2c-41be-ab1a-9a9f6414e3cf"
            },
            new Musics{
                Id=6,
                MusicName = "Self Control",
                ArtistName = "Laura Branigan",
                MusicUrl = "https://firebasestorage.googleapis.com/v0/b/musics-e3bba.appspot.com/o/Laura%20Branigan%20-%20Self%20Control.mp3?alt=media&token=2cfd4681-e6a9-453e-8726-e1ae12f71892"
            },
            new Musics{
                Id=7,
                MusicName = "Big in Japan",
                ArtistName = "Alphaville",
                MusicUrl = "https://firebasestorage.googleapis.com/v0/b/musics-e3bba.appspot.com/o/Alphaville%20-%20Big%20In%20Japan%20(Official%20Music%20Video).mp3?alt=media&token=7d837a6b-789f-43c0-9eed-2635657d75df"
            },
            new Musics
            {
                Id=8,
                MusicName = "Pump It",
                ArtistName ="Black Eyed",
                MusicUrl = "https://firebasestorage.googleapis.com/v0/b/musics-e3bba.appspot.com/o/Black%20Eyed%20Peas%20-%20Pump%20It%20(Lyrics)%20let%20those%20speakers%20blow%20your%20mind.mp3?alt=media&token=42392f2e-45e7-4bb2-acc7-893d194fd00c"
            }
        };

        //Get 
        [HttpGet]
        public async Task<ActionResult<List<Musics>>> GetMusics()
        {
            return Ok(musics);
        }
    }
}
