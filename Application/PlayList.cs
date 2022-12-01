﻿
using  MusicSymphony.Utility;

using MusicSymphony.Exceptions;

namespace MusicSymphony.Application
{
    internal partial class PlayList
    {
        InputChecker inputChecker = new();
        Music music = new();
        public string Title { get; set; }
    
        public List<Music> playlist = new();

        public void Run()
        {
            Utility.Utility.PlaylistMenu();
         Init: try
            {
                
                Console.WriteLine($"Playlist : {Title} ");

                Utility.Utility.DisplayPlaylistMenu();
                var option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        Console.Clear();
                        AddMusic();
                        goto Init;

                    case 2:
                        Console.Clear();
                        DisplayMusic(playlist);
                        goto Init;

                    case 3:
                        Console.Clear();
                        AlphabeticDisplay();
                        goto Init;

                    case 4:
                        Console.Clear();
                        ShuffleMusic();
                        goto Init;

                    case 5:
                        Console.Clear();
                        EditMusic();
                        goto Init;

                    case 6:
                        Console.Clear();
                        RemoveMusic();
                        goto Init;
                    case 7:
                        Console.WriteLine("\n Thanks For using our playlist. Press any key to exit ");
                        Environment.Exit(0000);
                        break;
                    default:
                        Console.WriteLine("Wrong Option. Please Try again");
                        goto Init;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Init;
            }
        }


        public void AddMusic()
        {
            music.AddNewMusic();
            playlist.Add(music._newMusic);
                       
        }
        public void DisplayMusic(List<Music> playlist)
        {
            foreach (var item in playlist)
            {
                Console.WriteLine($"Title : {item.Title}");
            }
            
        }
        public void ShuffleMusic()
        {
            var shuffledList = Utility.Utility.Shuffle(playlist);
            DisplayMusic(shuffledList);
        }
        public void EditMusic()
        {
            try
            {
                Console.WriteLine("Enter Music Title");
                var title = Console.ReadLine().Trim().ToLower();
                Console.WriteLine("Enter New Title");
                var newTitle = Console.ReadLine().Trim().ToLower();
                bool isTitleNull = inputChecker.NullValidator(newTitle, "Title can't be empty");
                foreach (var item in playlist)
                {
                    if (title == item.Title.ToLower() && isTitleNull == false)
                    {
                        item.Title = newTitle;
                    }
                    else
                    {
                       Utility.Utility.NotFound(title);
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void DisplayMusicByGenre()
        {
            Console.WriteLine("Enter genre");
            var genre = Console.ReadLine().Trim().ToLower();
            foreach (var item in playlist)
            {
                if (item.Genre != null && item.Genre.ToLower() == genre)
                {
                    Console.WriteLine($"Title : {item.Title}");
                    Console.WriteLine($"Artist : {item.Artist}");
                }
                else
                {
                    Utility.Utility.NotFound(genre);
                }
            }
        }
    }
}
