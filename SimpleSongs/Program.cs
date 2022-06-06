// See https://aka.ms/new-console-template for more information
using Database.Context;
using Database.DAO;
using SimpleSongs.Controller;
using SimpleSongs.Utils;
using SimpleSongs.View;
SongsHandler handler = new(new SongDao(new SongsContext()), new SongView(), new MenuDisplay(), new ConsoleInputSystem());
handler.Run();