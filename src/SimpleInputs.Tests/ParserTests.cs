using System;
using System.Globalization;
using Xunit;
using SimpleInputs.Parsing;

// Use explicit typing for tests to avoid type inference
namespace SimpleInputs.Tests
{
    public class SimpleInputsParsing
    {
        [Fact]
        public void Parser_ConvertsIntCorrectly()
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextInt();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<int>();
                Assert.Equal(t2Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsFloatCorrectly()
        {
            for (float i = 0; i < float.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextFloat();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<float>();
                Assert.Equal(t2Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsDoubleCorrectly()
        {
            for (double i = 0; i < double.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextDouble();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<double>();
                Assert.Equal(t2Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsDecimalCorrectly()
        {
            for (decimal i = 0; i < decimal.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextDecimal();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<decimal>();
                Assert.Equal(t2Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsLongCorrectly()
        {
            for (long i = 0; i < long.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextLong();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<long>();
                Assert.Equal(t2Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsSByteCorrectly()
        {
            for (sbyte i = 0; i < sbyte.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                var t1Value = temp.NextSByte();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<sbyte>();
                Assert.Equal(t2Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsByteCorrectly()
        {
            for (byte i = 0; i < byte.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextByte();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<byte>();
                Assert.Equal(t1Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsUIntCorrectly()
        {
            for (uint i = 0; i < uint.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextUInt();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<uint>();
                Assert.Equal(t2Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsShorkCorrectly()
        {
            for (short i = 0; i < short.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextShort();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<short>();
                Assert.Equal(t2Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsULongCorrectly()
        {
            for (ulong i = 0; i < ulong.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextULong();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<ulong>();
                Assert.Equal(t2Value, i);
            }
        }
        
        [Fact]
        public void Parser_ConvertsUShortCorrectly()
        {
            for (ushort i = 0; i < ushort.MaxValue; i++)
            {
                var temp = i.ToString(CultureInfo.InvariantCulture);
                
                var t1Value = temp.NextUShort();
                Assert.Equal(t1Value, i);

                var t2Value = temp.Next<ushort>();
                Assert.Equal(t2Value, i);
            }
        }
    }
}