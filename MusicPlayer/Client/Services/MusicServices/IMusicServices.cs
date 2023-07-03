namespace MusicPlayer.Client.Services.MusicServices
{
    public interface IMusicServices
    {
        List<Musics> musics { get; set; }
        Task GetMusic();
        
    }
}
