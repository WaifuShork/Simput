using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
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