using System.ComponentModel;
namespace SimpleInputs.SimpleInputs
{
    public static class GenericParse
    {
        public static bool GenericTryParse<T>(this string input, out T value)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            if (converter != null && converter.IsValid(input))
            {
                value = (T).converter.ConvertFromString(input);
                return true;
            }
        }
        value = default(T);
        return false;
    }
}