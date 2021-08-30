namespace SimpleInputs
{
    using Extensions;
    
    public static class Input
    {
        public static T Next<T>(this string input) where T : struct
        {
            return input.ParseValue<T>();
        }
        
        public static ushort NextUShort(this string input)
        {
            return input.ParseValue<ushort>();
        }
        
        public static ulong NextULong(this string input)
        {
            return input.ParseValue<ulong>();
        }
        
        public static uint NextUInt(this string input)
        {
            return input.ParseValue<uint>();
        }
        
        public static short NextShort(this string input)
        {
            return input.ParseValue<short>();
        }
        
        public static byte NextByte(this string input)
        {
            return input.ParseValue<byte>();
        }
        
        public static sbyte NextSByte(this string input)
        {
            return input.ParseValue<sbyte>();
        }
        
        public static long NextLong(this string input)
        {
            return input.ParseValue<long>();
        }
        
        public static int NextInt(this string input)
        {
            return input.ParseValue<int>();
        }
        
        public static float NextFloat(this string input)
        {
            return input.ParseValue<float>();
        }
        
        public static double NextDouble(this string input)
        {
            return input.ParseValue<double>();
        }
        
        public static decimal NextDecimal(this string input)
        {
            return input.ParseValue<decimal>();
        }
        
        /*public static T Next<T>() where T : struct
        {
            object outVal;
            var typeName = typeof(T).Name;
            var tryParse = Enum.TryParse(typeName, out StandardTypes type);
            if (!tryParse)
            {
                throw new InvalidEnumArgumentException();
            }

            switch (type)
                {
                    case StandardTypes.SByte:
                    {
                        sbyte inputValue = NextSByte(output, warning);
                        outVal = inputValue;
                        break;
                    }

                    case StandardTypes.Int16:
                    {
                        short inputValue = NextShort(output, warning);
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.UInt16:
                    {
                        ushort inputValue = NextUShort(output, warning);
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Int32:
                    {
                        int inputValue = NextInt(output, warning);
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.UInt32:
                    {
                        uint inputValue = NextUInt(output, warning);
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Int64:
                    {
                        long inputValue = NextLong(output, warning);
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.UInt64:
                    {
                        ulong inputValue = NextULong(output, warning);
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Single:
                    {
                        float inputValue = NextFloat(output, warning);
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Double:
                    {
                        double inputValue = NextDouble(output, warning);
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Decimal:
                    {
                        decimal inputValue = NextDecimal(output, warning);
                        outVal = inputValue;
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            return (T)outVal;
        }
    }*/
    }
}
