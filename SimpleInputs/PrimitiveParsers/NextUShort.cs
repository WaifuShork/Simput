using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a ushort
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>ushort</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static ushort NextUShort(string input = null, string output = null, string warning = null)
        {
            ushort uShortParse = ParsingUtilities.ParseLoop<ushort>(input, output, warning);
            return uShortParse;
        }
    }
}