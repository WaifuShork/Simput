using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a double
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>double</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static double NextDouble(string input = null, string output = null, string warning = null)
        {
            double doubleParse = ParsingUtilities.ParseLoop<double>(input, output, warning);
            return doubleParse;
        }
    }
}