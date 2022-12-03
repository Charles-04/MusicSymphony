using MusicSymphony.Exceptions;
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
        InputChecker inputChecker = new InputChecker(); 
        public string Title { get; init; } = "Music Symphony";
        public Dictionary<string, PlayList> Symphonyfy = new();

        public void MakeList() => Utility.Utility.MainMenu();
        public void Jam() => Utility.Utility.Jam();





        public void AddNewPlaylist()
        {
        Add: try
            {
                playlist.AddNewList();
                if (playlist._musicList != null)
                {
                    Symphonyfy.Add(playlist._musicList.Title.ToLower(), playlist._musicList);
                }
              
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Playlist creation failed. Please Try again");
                goto Add;
            }
        }
        public void RemovePlayList()
        {
            Console.WriteLine("Enter PlayList name");
            var name = Console.ReadLine().ToLower();
            if (Symphonyfy.ContainsKey(name))
            {
                Symphonyfy.Remove(name);
            }
            else
            {
                Utility.Utility.NotFound(name);
            }
        }
        public void DisplayAllMusic()
        {
            int count = 0;
            foreach (var music in Symphonyfy.Values)
            {
                music.AlphabeticDisplay();
                count += music.playlist.Count;
            }
            Console.WriteLine($"Total Music Equals {count}");
        }
        public void DisplayPlaylists()
        {
            Console.WriteLine($"Total Playlist equals : {Symphonyfy.Count}");
            foreach (var music in Symphonyfy.Values)
            {
                Console.WriteLine($"Name : {music.Title} \n Number of Music : {music.playlist.Count}");
            }
        }
        public void DisplayShuffledMusic()
        {
            foreach (var music in Symphonyfy.Values)
            {
                music.ShuffleMusic();
            }
        }
        public void GotoPlaylist()
        {
            if (Symphonyfy.Count <= 0)
            {
                Console.WriteLine("Playlist empty");
            }
            else
            {

                Console.WriteLine("Enter PlayList name");
                var title = Console.ReadLine().Trim().ToLower();
                if (Symphonyfy.ContainsKey(title) == false)
                {
                    Utility.Utility.NotFound(title);
                }
                else
                {
                    foreach (var music in Symphonyfy.Values)
                    {
                        if (music.Title.ToLower() == title)
                        {
                            music.Run();
                        }
                    }
                }
            }


        }
        public void EditPlayList()
        {
            Console.WriteLine("Enter PlayList name");
            var title = Console.ReadLine().ToLower();
            Console.WriteLine("Enter New Title");
            var newTitle = Console.ReadLine().Trim().ToLower();
            bool isTitleNull = inputChecker.NullValidator(newTitle, "Title can't be empty");
            foreach (var music in Symphonyfy.Values)
            {
                if (music.Title.ToLower() == title && isTitleNull == false)
                {
                    music.Title = newTitle;
                    Console.WriteLine($"Music tiltle changed to {music.Title}");
                }
                else
                {
                    Utility.Utility.NotFound(title);
                }
            }
        }
    }
}
