namespace SimpleSongs.Exceptions
{
    public class EmptyAuthorException : Exception
    {
        public EmptyAuthorException()
        {

        }

        public EmptyAuthorException(string? message) : base(message)
        {
        }

        public EmptyAuthorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
