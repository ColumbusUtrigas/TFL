namespace TFL.Entities;

public class ApiError
{
    public DateTime TimestampUtc;
    public string Name;
    public string ExceptionType;
    public int HttpStatusCode;
    public System.Net.HttpStatusCode HttpStatus;
    public string RelativeUri;
    public string Message;
    public string DetailedMessage;
}