using System;

namespace SimpleInputs.Utilities
{
    public static class ParsingUtilities
    {
        public static T ParseLoop<T>(string input = null, string output = null, string warning = null)
        {
            output ??= OutputExtensions.output;
            T result; 
            while (true)
            {
                if (input == null)
                {
                    Console.Write(output);
                }
                
                input ??= Console.ReadLine();

                if (Input.GenericTryParse(input, out result))
                    return result;
                
                if (string.IsNullOrEmpty(input))
                    break;

                Console.ForegroundColor = ConsoleColor.Red;
                if (warning == null)
                {
                    string inputValMessage = RegexFormatExtension.RegexStringFormatter(input);
                    warning = $"[Warning!] expected {typeof(T).Name}, received [{inputValMessage}], please enter correct value!";
                    Console.WriteLine($"{warning}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{warning}");
                    Console.ResetColor();
                }
                warning = null;
                input = null;
            }       
            return result;
        }
    }
}