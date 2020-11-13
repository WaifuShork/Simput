using System;
using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
    {
        /// <summary>
        /// Parses a string input, and forces the return as a short
        /// </summary>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>short</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static short NextShort(string output = null, string warning = null)
        {
            output ??= OutputExtensions.output;
            while (true)
            {
                
                Console.Write(output);
                string input = Console.ReadLine();
                if (short.TryParse(input, out short result))
                    return result;

                if (input == null) continue;
                Console.ForegroundColor = ConsoleColor.Red;
                if (warning == null)
                {
                    string inputValMessage = RegexFormatExtension.RegexStringFormatter(input);
                    warning = $"[Warning!] expected short, received [{inputValMessage}], please enter correct value!";
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