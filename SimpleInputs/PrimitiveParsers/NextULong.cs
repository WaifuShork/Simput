using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a ulong
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>ulong</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static ulong NextULong(string input = null, string output = null, string warning = null)
        {
            ulong uLongParse = ParsingUtilities.ParseLoop<ulong>(input, output, warning);
            return uLongParse;
        }
    }
}