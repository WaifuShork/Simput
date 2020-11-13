using System;
using System.Text.RegularExpressions;
using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as an int
        /// </summary>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>int</returns>
        public static int NextInt(string output = null, string warning = null)
        {
            output ??= OutputExtensions.output;
            while (true)
            {
                string input = default;
                Console.Write(output);
                if (int.TryParse(input = Console.ReadLine(), out int result))
                    return result;

                if (input == null) continue;
                Console.ForegroundColor = ConsoleColor.Red;
                if (warning == null)
                {
                    string inputValMessage = RegexFormatExtension.RegexFormatter(input);
                    warning = $"[Warning!] expected int, received [{inputValMessage}], please enter correct value!";
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