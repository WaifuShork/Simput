using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses a string input, and forces the return as a float
        /// </summary>
        /// <param name="output"></param>
        /// <returns>float</returns>
        public static float NextFloat(string output= null)
        {
            float inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!float.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}