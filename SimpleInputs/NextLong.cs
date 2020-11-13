using System;
using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a long
        /// </summary>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>long</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static long NextLong(string output = null, string warning = null)
        {
            output ??= OutputExtensions.output;
            while (true)
            {
                Console.Write(output);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                    return result;

                if (input == null) continue;
                Console.ForegroundColor = ConsoleColor.Red;
                if (warning == null)
                {
                    string inputValMessage = RegexFormatExtension.RegexStringFormatter(input);
                    warning = $"[Warning!] expected long, received [{inputValMessage}], please enter correct value!";
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