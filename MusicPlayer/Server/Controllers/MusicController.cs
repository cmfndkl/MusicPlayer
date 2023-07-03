using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicPlayer.Shared;

namespace MusicPlayer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {

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
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Musics>>> GetMusics()
        {
            return Ok(musics);
        }
    }
}
