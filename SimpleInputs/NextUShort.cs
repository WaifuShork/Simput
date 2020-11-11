using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a ushort
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ushort NextUShort(string output = null)
        {
        
            ushort inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!ushort.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}