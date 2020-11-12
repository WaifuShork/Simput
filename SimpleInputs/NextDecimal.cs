using System;
using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a decimal
        /// </summary>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>decimal</returns>
        public static decimal NextDecimal(string output = null, string warning = null)
        {
            decimal inputValue = default;
            bool input = default;
            output ??= OutputExtensions.output;
            do
            {
                string value = default;
                Console.Write(output);
                input = decimal.TryParse(value = Console.ReadLine(), out inputValue);
                if (!input)
                {
                    if (warning == null);
                    {
                        if (value != null)
                            warning = $"[Warning!] expected decimal, received [{value.Trim()}], please enter correct value!";
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{warning}");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            while (!input);
            return inputValue;
        }
    }
}