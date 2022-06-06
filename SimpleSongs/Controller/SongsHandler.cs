using Database.DAO;
using Database.DAO.Interface;
using Database.Entities;
using SimpleSongs.Factories;
using SimpleSongs.Utils.Interfaces;
using SimpleSongs.View.Interfaces;

namespace SimpleSongs.Controller
{
    public class SongsHandler
    {
        private ISongDao _SongDao;
        private IView<Song> _SongsView;
        private IMenuDisplay _MenuDisplay;
        private IInputSystem _InputSystem;
        private SongFactory _Factory;
        private string[] _AvailableCommands;

        public SongsHandler(ISongDao songDao, IView<Song> songsView, IMenuDisplay menuDisplay, IInputSystem inputSystem)
        {
            _SongDao = songDao;
            _SongsView = songsView;
            _MenuDisplay = menuDisplay;
            _InputSystem = inputSystem;
            _Factory = new(inputSystem);
            _AvailableCommands = new string[] { "\t1. Add new song", "\t2. Delete song", "\t3. View single song",
            "\t4. View all songs", "\t5. View all songs sorted by title", "\t6. Quit"};

        }

        private void Add()
        {
            var newSong = _Factory.GetNewSong();
            if (_SongDao.GetSong(Song => Song.Title == newSong.Title && Song.Author == newSong.Author) != null)
            {
                _MenuDisplay.PrintAndWaitForKey("There is already song with that title and author");
                return;
            }
            _SongDao.AddSong(newSong);
            _MenuDisplay.PrintAndWaitForKey("Song was successfully added, press any key to continue");

        }

        private void Delete()
        {
            var list = _SongDao.GetAllSongs();
            _SongsView.DisplayAll(list);
            var choice = _InputSystem.FetchIntValue("Type index of song you want to delete");
            bool isValidChoice = (choice - 1) < list.Count && choice > 0;
            if (isValidChoice) _SongDao.DeleteSong(list[choice - 1]); 
            else _MenuDisplay.PrintAndWaitForKey("Incorrect index, press any key to continue");
        }

        private void ViewSingle()
        {

            var name = _InputSystem.FetchStringValue("Type title of song");
            var author = _InputSystem.FetchStringValue("Type author of song");
            var song = _SongDao.GetSong(Song => Song.Title == name && Song.Author == author);
            if (song == null)
            {
                _MenuDisplay.PrintAndWaitForKey("There is no song with that title and author");
                return;
            }
            _SongsView.DisplaySingle(song);
            _MenuDisplay.PrintAndWaitForKey("Press any key to continue");
        }

        private void ViewAll(bool Sorted = false)
        {
            List<Song> list;
            if (Sorted)
            {
                list = _SongDao.GetAllSongs().OrderBy(Song => Song.Title).ToList();
            }
            else list = _SongDao.GetAllSongs();
            _SongsView.DisplayAll(list);
            _MenuDisplay.PrintAndWaitForKey("Press any key to continue");
        }

        public void Run()
        {
            _MenuDisplay.PrintIntro();
            bool isRunning = true;
            while(isRunning)
            {
                _MenuDisplay.ClearScreen();
                _MenuDisplay.PrintMany(_AvailableCommands.ToList());
                var choice = _InputSystem.FetchStringValue("Choose option by writing it's number");
                _MenuDisplay.ClearScreen();
                switch (choice)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Delete();
                        break;
                    case "3":
                        ViewSingle();
                        break;
                    case "4":
                        ViewAll();
                        break;
                    case "5":
                        ViewAll(true);
                        break;
                    case "6":
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
