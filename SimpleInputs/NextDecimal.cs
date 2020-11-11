using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a decimal
        /// </summary>
        /// <param name="output"></param>
        /// <returns>decimal</returns>
        public static decimal NextDecimal(string output = null)
        {
            decimal inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!decimal.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}