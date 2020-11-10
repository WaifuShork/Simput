using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a ulong
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ulong NextULong(string output)
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