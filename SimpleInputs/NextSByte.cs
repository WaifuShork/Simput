using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as an sbyte
        /// </summary>
        /// <param name="output"></param>
        /// <returns>sbyte</returns>
        public static sbyte NextSByte(string output = null)
        {
            sbyte inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!sbyte.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}