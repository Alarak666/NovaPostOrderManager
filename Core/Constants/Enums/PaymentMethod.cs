using System.ComponentModel;

namespace Core.Constants.Enums;

public enum PaymentMethod
{
    [Description("Готівка")]
    Cash,
    [Description("Безготівка")]
    NonCash
}