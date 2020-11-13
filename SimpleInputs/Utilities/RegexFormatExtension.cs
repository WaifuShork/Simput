using System.Text.RegularExpressions;

namespace SimpleInputs.Utilities
{
    public class RegexFormatExtension
    {
        public static string RegexFormatter(string input)
        {
            string inputValMessage = Regex.Replace(input, @"\s+", " ");
            return inputValMessage;
        }
    }
}