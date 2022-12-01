


using MusicSymphony.Exceptions;

namespace MusicSymphony.Application
{
    internal partial class PlayList
    {
        InputChecker inputChecker = new();
        Music music = new();
        public string Title { get; set; }
        public List<Music> playlist = new();


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
            Console.WriteLine("Enter Music Title");
            var title = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Enter New Title");
            var newTitle = Console.ReadLine().Trim().ToLower();
            bool isTitleNull = inputChecker.NullValidator(newTitle, "Title can't be empty");
            foreach (var item in playlist)
            {
                if (title == item.Title && isTitleNull == false)
                {
                    item.Title = newTitle;
                }
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
                    Console.WriteLine($"No song found for genre {genre}");
                }
            }
        }
    }
}
