using System;
using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a ulong
        /// </summary>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <returns>ulong</returns>
        public static ulong NextULong(string output = null, string warning = null)
        {
            ulong inputValue;
            bool input = default;
            output ??= OutputExtensions.output;
            do
            {
                string value = default;
                Console.Write(output);
                input = ulong.TryParse(value = Console.ReadLine(), out inputValue);
                if (!input)
                {
                    if (warning == null)
                    {
                        if (value != null)
                            warning = $"[Warning!] expected sbyte, received [{value.Trim()}], please enter correct value!";
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