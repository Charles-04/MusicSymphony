using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSymphony.Application
{
    internal class MusicPlayer
    {
        PlayList playlist = new();
        public string Title { get; init; } = "Music Symphony";
        public Dictionary<string, PlayList> Symphonyfy = new();

        public void AddNewPlaylist()
        {
            playlist.AddNewList();
            Symphonyfy.Add(playlist._musicList.Title, playlist._musicList);    
        }
    }
}
