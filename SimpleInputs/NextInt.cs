using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
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