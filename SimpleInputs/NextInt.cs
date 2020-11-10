using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as an int
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static int NextInt(string output)
        {
            int inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!int.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}