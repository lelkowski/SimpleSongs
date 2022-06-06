using SimpleSongs.View.Interfaces;
using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongs.View
{
    public class SongView : IView<Song>
    {
        public void DisplayAll(List<Song> entities)
        {
            for(int i = 0 ; i < entities.Count; i++)
            {
                Console.WriteLine("~~~~~~~~~~~~ " + (i + 1) + " ~~~~~~~~~~~~");
                DisplaySingle(entities[i]);
            }
        }

        public void DisplaySingle(Song entity)
        {
            Console.WriteLine("Title : ''" + entity.Title + "''");
            Console.WriteLine("Author : " + entity.Author);
            Console.WriteLine("Album Name : ''" + entity.AlbumName + "''");
            Console.WriteLine("Length : " + entity.Length);
        }
    }
}
