using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a decimal
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>decimal</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static decimal NextDecimal(string input = null, string output = null, string warning = null)
        {
            decimal decimalParse = ParsingUtilities.ParseLoop<decimal>(input, output, warning);
            return decimalParse;
        }
    }
}