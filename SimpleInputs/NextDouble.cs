using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
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