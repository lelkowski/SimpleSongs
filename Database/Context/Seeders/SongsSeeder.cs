using Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Context.Seeders
{
    public static class SongsSeeder
    {
        public static void SeedDatabase(this ModelBuilder builder)
        {
            List<Song> songs = new();
            songs.Add(new Song("Speak to Me", "Pink Floyd", "The Dark Side of the Moon", 3.58) { Id = 1});
            songs.Add(new Song("Bad", "Michael Jackson", "Bad", 3.58) { Id = 2});
            songs.Add(new Song("Speed Demon", "Michael Jackson", "Bad", 3.58) { Id = 3});

            builder.Entity<Song>().HasData(songs);
        }
    }
}
