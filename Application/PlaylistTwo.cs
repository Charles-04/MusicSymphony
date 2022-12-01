using MusicSymphony.Exceptions;
namespace MusicSymphony.Application
{
    internal partial class PlayList
    {
        PlayList _musicList;

        

        public void AlphabeticDisplay()
        {
            var sortedList = playlist.OrderBy(music => music.Title);
            DisplayMusic((List<Music>)sortedList);

        }

        public void AddNewList()
        {
        AddNew: try
            {
                PlayList newPlaylist = new();
                Console.WriteLine("Enter Playlist Name");
                string name = Console.ReadLine().Trim();
                bool isNameNull = inputChecker.NullValidator(name, "Name can't be empty");
                Console.WriteLine("Do you want to add music?");
                string option = Console.ReadLine().Trim();
                bool isOptionNull = inputChecker.NullValidator(option, "Option can't be empty");

            }
            catch (InputNullException)
            {

                throw;
            }
        }
    }
}
