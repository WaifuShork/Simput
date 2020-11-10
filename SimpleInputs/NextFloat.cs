using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static float NextFloat(string output)
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