using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static uint NextUInt(string output)
        {
            uint inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!uint.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}