using System.ComponentModel;
namespace SimpleInputs
{
    public static partial class Input
    {
        public static bool GenericTryParse<T>(this string input, out T value)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));

            if (converter.IsValid(input))
            {
                value = (T)converter.ConvertFromString(input);
                return true;
            }
            value = default;
            return false;
        }
    }
}