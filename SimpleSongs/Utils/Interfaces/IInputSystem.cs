namespace SimpleSongs.Utils.Interfaces
{
    public interface IInputSystem
    {
        double FetchDoubleValue(string message);
        string FetchStringValue(string message);
        int FetchIntValue(string message);
    }
}