using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a short
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>short</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static short NextShort(string input = null, string output = null, string warning = null)
        {
            short shortParse = ParsingUtilities.ParseLoop<short>(input, output, warning);
            return shortParse;
        }
    }
}