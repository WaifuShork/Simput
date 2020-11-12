using System;
using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class NextInput
    {
        /// <summary>
        /// Parses an input based on the passed value into the generic.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="warning"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Next<T>(string output = null, string warning = null) where T : struct
        {
            object outVal = default;
            string typeName = typeof(T).Name;
            Enum.TryParse(typeName, out StandardTypes type);

                switch (type)
                {
                    case StandardTypes.SByte:
                    {
                        sbyte inputValue = NextSByte();
                        outVal = inputValue;
                        break;
                    }

                    case StandardTypes.Int16:
                    {
                        short inputValue = NextShort();
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.UInt16:
                    {
                        ushort inputValue = NextUShort();
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Int32:
                    {
                        int inputValue = NextInt();
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.UInt32:
                    {
                        uint inputValue = NextUInt();
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Int64:
                    {
                        long inputValue = NextLong();
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.UInt64:
                    {
                        ulong inputValue = NextULong();
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Single:
                    {
                        float inputValue = NextFloat();
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Double:
                    {
                        double inputValue = NextDouble();
                        outVal = inputValue;
                        break;
                    }
                    case StandardTypes.Decimal:
                    {
                        decimal inputValue = NextDecimal();
                        outVal = inputValue;
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            return (T)outVal;
        }
    }
}
