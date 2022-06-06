using SimpleSongs.View.Interfaces;
using Database.Entities;

namespace SimpleSongs.View
{
    public class SongView : IView<Song>
    {
        public void DisplayAll(List<Song> entities)
        {
            for(int i = 0 ; i < entities.Count; i++)
            {
                Console.WriteLine("\t~~~~~~~~~~~~ " + (i + 1) + " ~~~~~~~~~~~~");
                DisplaySingle(entities[i]);
            }
        }

        public void DisplaySingle(Song entity)
        {
            Console.WriteLine("\tTitle : ''" + entity.Title + "''");
            Console.WriteLine("\tAuthor : " + entity.Author);
            Console.WriteLine("\tAlbum Name : ''" + entity.AlbumName + "''");
            Console.WriteLine("\tLength : " + entity.Length);
        }
    }
}
