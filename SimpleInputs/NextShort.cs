using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a short
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static short NextShort(string output)
        {
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