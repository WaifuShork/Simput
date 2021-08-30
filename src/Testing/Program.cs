using System;
using SimpleInputs;

namespace Testing
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            var menu = new string[10];

            for (var i = 0; i < menu.Length; i++)
            {
                menu[i] = (i + 12).ToString();
            }
            
            var item = MenuInput.DrawMenu(menu, out var index);
            Console.WriteLine(index);
            Console.ResetColor();
        }
    }
}