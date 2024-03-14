
using FluentValidation.Results;

namespace ApplicationManager.Helpers;

public static class ValidationResultExtensions
{
    public static bool IsValidField(this ValidationResult result, string propertyName)
    {
        return result.Errors.All(e => !e.PropertyName.Contains(propertyName));
    }
}