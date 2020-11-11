using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a short
        /// </summary>
        /// <param name="output"></param>
        /// <returns>short</returns>
        public static short NextShort(string output = null)
        {
            short inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!short.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}