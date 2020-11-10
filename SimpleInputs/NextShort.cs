using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static short NextShort(string output)
        {
            /// <summary>
        /// Parses a string input, and forces the return as a short
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
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