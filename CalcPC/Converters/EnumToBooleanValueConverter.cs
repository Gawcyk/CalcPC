using System.Globalization;

using CalcPC.BaseType;

namespace CalcPC.Converters;

public class EnumToBooleanValueConverter : BaseMarkupValueConverter
{
    public required Type EnumType
    {
        get; set;
    }
    protected override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (parameter is string enumString)
        {
            if (value is not null && Enum.IsDefined(EnumType, value))
            {
                var enumValue = Enum.Parse(EnumType, enumString);

                return enumValue.Equals(value);
            }
        }

        return false;
    }

    protected override object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return parameter is string enumString ? Enum.Parse(EnumType, enumString) : null;
    }
}
