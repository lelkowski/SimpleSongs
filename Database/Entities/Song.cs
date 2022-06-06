using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AlbumName { get; set; }
        public double Length { get; set; }

        public Song(string title, string author, string albumName, double length)
        {
            Title = title;
            Author = author;
            AlbumName = albumName;
            Length = length;
        }

        public Song()
        {

        }
    }
}
