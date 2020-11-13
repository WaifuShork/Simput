using System.Text.RegularExpressions;

namespace SimpleInputs.Utilities
{
    public static class RegexFormatExtension
    {
        public static string RegexStringFormatter(string input)
        {
            string inputValMessage = Regex.Replace(input, @"\s+", " ");
            return inputValMessage;
        }
    }
}