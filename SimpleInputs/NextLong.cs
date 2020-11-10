using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a long
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static long NextLong(string output)
        {
            long inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!long.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}