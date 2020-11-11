using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a uint
        /// </summary>
        /// <param name="output"></param>
        /// <returns>uint</returns>
        public static uint NextUInt(string output = null)
        {
            
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