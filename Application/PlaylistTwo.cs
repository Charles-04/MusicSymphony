using MusicSymphony.Exceptions;
namespace MusicSymphony.Application
{
    internal partial class PlayList
    {
        public PlayList ?_musicList;

        

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
                   

                AddMusic: Console.WriteLine("Do you want to add music?");
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
    }
}
