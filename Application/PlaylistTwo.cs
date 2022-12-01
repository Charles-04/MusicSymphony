using MusicSymphony.Exceptions;
namespace MusicSymphony.Application
{
    internal partial class PlayList
    {
        public PlayList? _musicList;



        public void AlphabeticDisplay()
        {
            var sortedList = playlist.OrderBy(music => music.Title).ToList();
            DisplayMusic(sortedList);

        }

        public void AddNewList()
        {
        AddNew: try
            {
                PlayList newPlaylist = new();
                Console.WriteLine("Enter Playlist Name");
                string name = Console.ReadLine().Trim();
                bool isNameNull = inputChecker.NullValidator(name, "Name can't be empty");

                if (isNameNull == false)
                {
                    newPlaylist.Title = name;


                AddMusic: Console.WriteLine("Do you want to add music? \n Press N for No or Y for Yes");
                    string option = Console.ReadLine().Trim().ToLower();
                    if (option == "y")
                    {
                        newPlaylist.AddMusic();
                        goto AddMusic;
                    }
                    else if (option == "n")
                    {
                        Console.WriteLine("Playlist added");
                    }

                    _musicList = newPlaylist;
                }

            }
            catch (InputNullException ex)
            {
                Console.WriteLine(ex.Message);
                goto AddNew;
            }
        }

        public void RemoveMusic()
        {
            try
            {
                Console.WriteLine("Enter Music Title");
                var title = Console.ReadLine().Trim().ToLower();
                foreach (var item in playlist)
                {
                    if (title == item.Title.ToLower())
                    {
                        playlist.Remove(item);
                    }
                    else
                    {
                        Utility.Utility.NotFound(title);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Play()
        {
            play: try
            {
                var count = 0;
                while (count <= playlist.Count)
                {
                    Console.Clear();
                    Console.WriteLine($"\n Currently Jamming {playlist[count].Title} \n Press N for Next \n Press P for previous \n E to exit");
                    var option = Console.ReadKey();
                    if (option.Key == ConsoleKey.N)
                    {
                        count++;
                    }
                    else if (option.Key == ConsoleKey.P)
                    {
                        count--;
                    }
                    else if (option.Key == ConsoleKey.E)
                    {
                        Run();
                    }
                    else
                    {
                        Console.WriteLine("Option invalid");
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto play;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto play;
            }
        }
    }
}