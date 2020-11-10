using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static sbyte NextSByte(string output)
        {
            sbyte inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!sbyte.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}