using AuthorizeCore.Constants.Enums;

namespace AuthorizeCore.Model;

public class ErrorInfo
{
    public ErrorType Type { get; set; }
    public string Message { get; set; }
}