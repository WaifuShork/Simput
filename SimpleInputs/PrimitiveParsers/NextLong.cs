using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a long
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>long</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static long NextLong(string input = null, string output = null, string warning = null)
        {
            long longParse = ParsingUtilities.ParseLoop<long>(input, output, warning);
            return longParse;
        }
    }
}