using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a uint
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>uint</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static uint NextUInt(string input = null, string output = null, string warning = null)
        {
            uint uintParse = ParsingUtilities.ParseLoop<uint>(input, output, warning);
            return uintParse;
        }
    }
}