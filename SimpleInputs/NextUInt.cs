using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static uint NextUInt(string output)
        {
            /// <summary>
        /// Parses a string input, and forces the return as a uint
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
            uint inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!uint.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}