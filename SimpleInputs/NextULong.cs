using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a ulong
        /// </summary>
        /// <param name="output"></param>
        /// <returns>ulong</returns>
        public static ulong NextULong(string output = null)
        {
        
            ulong inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!ulong.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}