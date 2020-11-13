using System;
using System.ComponentModel;
using SimpleInputs.Utilities;

namespace SimpleInputs
{
    public static partial class Input
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
            bool tryParse = Enum.TryParse(typeName, out StandardTypes type);
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
    }
}
