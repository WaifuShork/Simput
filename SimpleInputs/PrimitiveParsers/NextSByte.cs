using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as an sbyte
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>sbyte</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static sbyte NextSByte(string input = null, string output = null, string warning = null)
        {
            sbyte sbyteParse = ParsingUtilities.ParseLoop<sbyte>(input, output, warning);
            return sbyteParse;
        }
    }
}