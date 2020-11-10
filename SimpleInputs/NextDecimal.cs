using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        public static decimal NextDecimal(string output)
        {
            decimal inputValue;
            do
            {
                Console.Write(output);
            } 
            while (!decimal.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }
    }
}