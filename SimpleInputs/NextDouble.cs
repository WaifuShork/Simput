using System;
using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a double
        /// </summary>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>double</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static double NextDouble(string output = null, string warning = null)
        {
            output ??= OutputExtensions.output;
            while (true)
            {
                Console.Write(output);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                    return result;

                if (input == null) continue;
                Console.ForegroundColor = ConsoleColor.Red;
                if (warning == null)
                {
                    string inputValMessage = RegexFormatExtension.RegexStringFormatter(input);
                    warning = $"[Warning!] expected double, received [{inputValMessage}], please enter correct value!";
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