using MusicSymphony.Exceptions;
namespace MusicSymphony.Application
{
    
    internal class Music
    {
        InputChecker inputChecker = new();
        public Music _newMusic;
        private string _title;
        private string _artist;

        internal string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        internal string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        internal string Genre { get; set; }
        internal DateTime AddTime { get;set; }

        public void AddNewMusic()
        {
           AddMusic: try
            {
                Music music = new();

                Console.WriteLine("Enter music title");
                string title = Console.ReadLine().Trim();
                bool isTitleNull = inputChecker.NullValidator(title, "Title can't be empty");
                Console.WriteLine("Enter artist name");
                string artist = Console.ReadLine().Trim();
                bool isArtistNull = inputChecker.NullValidator(artist, "Artist's name can't be empty");
                Console.WriteLine("Enter music genre");
                string genre = Console.ReadLine().Trim();
                bool isGenreNull = inputChecker.NullValidator(genre, "Genre name can't be empty");

                DateTime addTime = DateTime.Now;





                if (isArtistNull == false && isGenreNull == false && isTitleNull == false)
                {
                    music.Title = title;
                    music.Artist = artist;
                    music.Genre = genre;
                    music.AddTime = addTime;

                    _newMusic = music;
                    
                }
               
            }
            catch (InputNullException ex)
            {
                Console.WriteLine(ex.Message);
                goto AddMusic;
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto AddMusic;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto AddMusic;
            }
        }
        internal void EditMusic(string Title)
        {
            _newMusic.Title = Title;
        }
    }
}
