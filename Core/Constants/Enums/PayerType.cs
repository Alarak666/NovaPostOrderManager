using System.ComponentModel;

namespace Core.Constants.Enums;

public enum PayerType
{
    [Description("Відправник")]
    Sender,
    [Description("Одержувач")]
    Recipient,
    [Description("Третя особа")]
    ThirdPerson
}