namespace SimpleInputs.Extensions
{
    using System;
    
    internal static class StringExtensions
    {
        internal static T ParseValue<T>(this string input)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                
                switch (input.GenericTryParse(out T result))
                {
                    case true:
                    {
                        return result;
                    }

                    case false:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: unable to parse value");
                        Console.ResetColor();
                        return default;
                    }
                }
            }

            return default;
        }
    }
}