using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSymphony.Application
{
    internal class MusicPlayer
    {
        public string Title { get; init; } = "Music Symphony";
        public List<PlayList> musicPlayer = new();
    }
}
