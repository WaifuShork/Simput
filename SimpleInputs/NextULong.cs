using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static ulong NextULong(string output)
        {
            ulong inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!ulong.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}