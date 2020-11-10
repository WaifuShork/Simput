using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static long NextLong(string output)
        {
            long inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!long.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}