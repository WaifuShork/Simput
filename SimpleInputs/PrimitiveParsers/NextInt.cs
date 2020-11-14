using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as an int
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>int</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static int NextInt(string input = null, string output = null, string warning = null)
        {
            int intParse = ParsingUtilities.ParseLoop<int>(input, output, warning);
            return intParse;
        }
    }
}