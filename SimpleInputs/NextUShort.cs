using System;
using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a ushort
        /// </summary>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>ushort</returns>
        public static ushort NextUShort(string output = null, string warning = null)
        {
            output ??= OutputExtensions.output;
            while (true)
            {
                string input = default;
                Console.Write(output);
                if (ushort.TryParse(input = Console.ReadLine(), out ushort result))
                    return result;

                if (input == null) continue;
                Console.ForegroundColor = ConsoleColor.Red;
                if (warning == null)
                {
                    string inputValMessage = RegexFormatExtension.RegexFormatter(input);
                    warning = $"[Warning!] expected ushort, received [{inputValMessage}], please enter correct value!";
                    Console.WriteLine($"{warning}");
                    warning = null;
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{warning}");
                    Console.ResetColor();
                }
            }
        }
    }
}