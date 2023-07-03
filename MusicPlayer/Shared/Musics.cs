using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Shared
{
    public class Musics
    {
        public int Id { get; set; }
        public string MusicName { get; set; } = string.Empty;
        public string ArtistName { get; set; } = string.Empty;
        public string MusicUrl { get; set; } = string.Empty;
    }
}
