using MusicSymphony.Application;
using MusicSymphony.Utility;
namespace MusicSymphony
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MusicPlayer musicPlayer = new MusicPlayer();
            musicPlayer.AddNewPlaylist();
        }
    }
}