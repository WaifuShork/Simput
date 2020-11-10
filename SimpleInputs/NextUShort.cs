using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static ushort NextUShort(string output)
        {
            ushort inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!ushort.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}