using System;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        private enum StandardType
        {
            SByte,
            Int16, UInt16, Int32, UInt32, Int64, UInt64,
            Float, Double, Decimal
        };
        
        /// <summary>
        /// Currently broken, DOT NOT CALL.
        /// </summary>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Next<T>(string output)
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
                            Console.Write(StandardType.SByte);

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
                            Console.Write(StandardType.Int16);
                        } 
                        while (short.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.UInt16:
                    {
                        ushort inputValue = default;
                        do
                        {
                            Console.Write(output);
                            Console.Write(StandardType.UInt16);
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
                            Console.Write(StandardType.Int32);


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
                            Console.Write(StandardType.UInt32);

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
                            Console.Write(StandardType.Int64);

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
                            Console.Write(StandardType.UInt64);

                        } 
                        while (!ulong.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                    case StandardType.Float:
                    {
                        float inputValue = default;
                        do
                        {
                            Console.Write(output);
                            Console.Write(StandardType.Float);

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
                            Console.Write(StandardType.Double);

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
                            Console.Write(StandardType.Decimal);

                        } 
                        while (!decimal.TryParse(Console.ReadLine(), out inputValue));
                        outVal = inputValue;
                        break;
                    }
                }
            return outVal;
        }
    }
}
