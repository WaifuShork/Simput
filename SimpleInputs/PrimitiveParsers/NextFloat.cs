using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a float
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>float</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static float NextFloat(string input = null, string output = null, string warning = null)
        {
            float floatParse = ParsingUtilities.ParseLoop<float>(input, output, warning);
            return floatParse;
        }
    }
}