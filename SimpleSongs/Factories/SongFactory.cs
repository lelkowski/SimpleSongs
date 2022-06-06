using Database.Entities;
using SimpleSongs.Exceptions;
using SimpleSongs.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleSongs.Factories
{
    public class SongFactory
    {
        private IInputSystem _InputSystem;

        public SongFactory(IInputSystem inputSystem)
        {
            _InputSystem = inputSystem;
        }

        public Song GetNewSong()
        {
            Regex regexName = new(@"^[A-Za-z\s]*$");
            string name, author, album;
            double length;
            bool isValid = false;
            do
            {
                name = _InputSystem.FetchStringValue("Type title of song(min. 2 letters)");
                isValid = (name.Length >= 2);
            } while (!isValid);
            do
            {
                author = _InputSystem.FetchStringValue("Type author of song(min. 2 letters)");
                isValid = (author.Length >= 2 && regexName.IsMatch(author));
            } while (!isValid);

            album = _InputSystem.FetchStringValue("Type name of album");
            do
            {
                length = _InputSystem.FetchDoubleValue("Type length of song");
                var seconds = length - Math.Truncate(length);
                isValid = (seconds >= 0 && seconds <0.6) && length > 0;

            } while(!isValid);

            if(author == null | author.Length == 0)
            {
                throw new EmptyAuthorException("Name of author cannot be empty");
            }

            return (new Song()
            {
                Title = name,
                Author = author,
                AlbumName = album,
                Length = length
            });
        }
    }
}
