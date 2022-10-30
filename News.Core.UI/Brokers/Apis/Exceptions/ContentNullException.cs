namespace News.Core.UI.Brokers.Apis.Exceptions;

public class ContentNullException : Exception
{
    public ContentNullException()
        : base("Content cannot be null")
    { }

    public ContentNullException(string message, Exception innerException)
        : base(message, innerException)
    { }
}