namespace News.Core.UI.Brokers.Apis.Exceptions;

public class ErrorResponseException : Exception
{
	public ErrorResponseException(string message)
		: base(message)
	{ }
}
