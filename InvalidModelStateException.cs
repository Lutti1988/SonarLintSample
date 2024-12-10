
namespace SonarLintIssueSample;


public class InvalidModelStateException : Exception
{
    public InvalidModelStateException()
    {
    }

    public InvalidModelStateException(string? message) : base(message)
    {
    }

    public InvalidModelStateException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}