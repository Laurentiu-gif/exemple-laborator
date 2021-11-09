using LanguageExt;
using static LanguageExt.Prelude;
using System.Text.RegularExpressions;

namespace Tema3_PSSC.Domain
{
    public record ProductCode
    {
        private static readonly Regex ValidPattern = new("^[0-9]{3}$");

    public string Code { get; }

    public ProductCode(string value)
    {
        if (ValidPattern.IsMatch(value))
        {
            Code = value;
        }
        else
        {
            throw new InvalidProductCodeException("");
        }
    }

    public override string ToString()
    {
        return Code;
    }

    private static bool IsValid(string stringValue) => ValidPattern.IsMatch(stringValue);

    public static Option<ProductCode> TryParse(string productCodeString)
    {
        if (IsValid(productCodeString))
        {
            return Some<ProductCode>(new(productCodeString));
        }
        else
        {
            return None;
        }
    }
}
}
