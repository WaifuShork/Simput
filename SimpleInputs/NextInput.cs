using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        private enum StandardType
        {
            SByte,
            Int16, UInt16, Int32, UInt32, Int64, UInt64,
            Single, Double, Decimal
        };
        
        /// <summary>
        /// Parses an input based on the passed value into the generic.
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Next<T>(string output = null)
        {
            dynamic outVal = default;
            string typeName = typeof(T).Name;
            Enum.TryParse(typeName, out StandardType type);

                switch (type)
                {
                    case StandardType.SByte:
                    {
                        sbyte inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!sbyte.TryParse(Console.ReadLine(), out inputValue));

                        outVal = inputValue;
                        break;
                    }
                    
                    case StandardType.Int16:
                    {
                        short inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!short.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.UInt16:
                    {
                        ushort inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!ushort.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.Int32:
                    {
                        int inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!int.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.UInt32:
                    {
                        uint inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!uint.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.Int64:
                    {
                        long inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!long.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.UInt64:
                    {
                        ulong inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!ulong.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.Single:
                    {
                        float inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!float.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.Double:
                    {
                        double inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!double.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.Decimal:
                    {
                        decimal inputValue = default;
                        do
                        {
                            Console.Write(output);
                        } 
                        while (!decimal.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            return outVal;
        }
    }
}
