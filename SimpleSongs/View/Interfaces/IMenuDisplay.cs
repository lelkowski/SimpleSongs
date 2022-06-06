namespace SimpleSongs.View.Interfaces
{
    public interface IMenuDisplay
    {
        void ClearScreen();
        void PrintAndWaitForKey(string content);
        void PrintMany<T>(List<T> entities);
        void PrintMessage(string content);
        void PrintIntro();
    }
}