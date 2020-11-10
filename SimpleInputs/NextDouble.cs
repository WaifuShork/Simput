using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a double
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static double NextDouble(string output)
        {
            double inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!double.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}