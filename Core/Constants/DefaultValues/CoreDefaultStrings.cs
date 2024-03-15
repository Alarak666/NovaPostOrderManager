namespace Core.Constants.DefaultValues;

public static class CoreDefaultStrings
{
    //MiddleWare
    public const string CustomExceptionText = "{0}";
    public const string BadRequestError = "Невірний запит. Будь ласка, перевірте введені дані.";
    public const string LoginFailedError = "Невдалий вхід. Неправильний логін або пароль.";
    public const string AlivePassword = "Невдалий вхід, термін дії пароля минув.\n Щоб змінити пароль, натисніть клавіші 'CTRL+ALT+DEL' та виберіть 'Змінити пароль'";
    public const string PersonPassword = "Потрібно ввести персональний пароль, або він не вірний";
    public const string AuthorizeException = "У вас немає доступу";

    //Validation
    public const string FieldEmpty = "Поле {0} не повино бути пустим";
}