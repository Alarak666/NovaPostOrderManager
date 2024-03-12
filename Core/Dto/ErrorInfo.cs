using Core.Constants.Enums;

namespace Core.Dto;

public class ErrorInfo
{
    public ErrorType Type { get; set; }
    public string Message { get; set; }

}