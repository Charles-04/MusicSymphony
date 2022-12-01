using MusicSymphony.Application;
using MusicSymphony.Utility;
namespace MusicSymphony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayList playList = new();
            MusicPlayer musicPlayer = new MusicPlayer();
            playList.MakeList();
            musicPlayer.MakeList();
            musicPlayer.Jam();
        }
    }
}