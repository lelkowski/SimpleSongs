using Database.Entities;

namespace Database.DAO.Interface
{
    public interface ISongDao
    {
        void DeleteSong(Song songToDelete);
        List<Song> GetAllSongs();
        Song GetSong(Func<Song, bool> condition);
        void UpdateSong(Song songToUpdate);
        void AddSong(Song songToAdd);
    }
}