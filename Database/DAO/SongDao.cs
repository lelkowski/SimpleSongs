using Database.Context;
using Database.DAO.Interface;
using Database.Entities;

namespace Database.DAO
{
    public class SongDao : ISongDao
    {
        private SongsContext _context;

        public SongDao(SongsContext context)
        {
            _context = context;
        }

        public List<Song> GetAllSongs()
        {
            return _context.Songs.ToList();
        }

        public Song GetSong(Func<Song, bool> condition)
        {
            return _context.Songs.FirstOrDefault(condition);
        }

        public void DeleteSong(Song songToDelete)
        {
            _context.Songs.Remove(songToDelete);
            _context.SaveChanges();
        }

        public void UpdateSong(Song songToUpdate)
        {
            _context.Songs.Update(songToUpdate);
            _context.SaveChanges();
        }

        public void AddSong(Song songToAdd)
        {
            _context.Songs.Add(songToAdd);
            _context.SaveChanges();
        }
    }
}
