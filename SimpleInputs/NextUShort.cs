using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static ushort NextUShort(string output)
        {
            /// <summary>
        /// Parses a string input, and forces the return as a ushort
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
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