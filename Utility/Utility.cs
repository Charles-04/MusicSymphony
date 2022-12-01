using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSymphony.Utility
{
    internal static class Utility
    {
        private static Random rng = new Random();
        private static StringBuilder _playlistMenu = new();
        private static StringBuilder _mainMenu = new();
        public static List<T> Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return (List<T>)list;
        }

        public static void MainMenu()
        {
            _mainMenu.AppendLine($"1 : Display all music");
            _mainMenu.AppendLine($"2 : Add new playlist");
            _mainMenu.AppendLine($"3 : Display all playlists");
            _mainMenu.AppendLine($"4 : Remove playlist");
            _mainMenu.AppendLine($"5 : Edit playlist");
            _mainMenu.AppendLine($"6 : Goto playlist");
            _mainMenu.AppendLine($"7 : Exit");

            Console.WriteLine(_mainMenu.ToString());

        }
        public static void PlaylistMenu()
        {
            _playlistMenu.AppendLine($"2 : Add new music");
            _playlistMenu.AppendLine($"1 : Display all music");
            _playlistMenu.AppendLine($"3 : Play in Alphabetic order");
            _playlistMenu.AppendLine($"4 : Play in shuffle mode");
            _playlistMenu.AppendLine($"5 : Edit playlist");
            _playlistMenu.AppendLine($"6 : Goto playlist");
            _playlistMenu.AppendLine($"7 : Exit");

            Console.WriteLine(_mainMenu.ToString());

        }
    }
}
