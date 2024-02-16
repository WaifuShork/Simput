using System;
using System.Text;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Numerics;

namespace Simput;

internal static class Parser
{
	internal static T Parse<T>(string input, out bool success) where T : struct, INumber<T>
	{
		try
		{
			success = true;
			var buffer = new StringBuilder();
			var hasDecimal = false;
			var hasSeparator = false;
			var isNegative = input[0] == '-';
			if (input[0] == '_' || isNegative && input[1] == '_')
			{
				success = false;
				return T.Zero;
			}

			for (var i = isNegative ? 1 : 0; i < input.Length; i++)
			{
				if (char.IsDigit(input[i]))
				{
					buffer.Append(input[i]);
					continue;
				}

				if (input[i] == '_' && i != 0)
				{
					if (hasSeparator)
					{
						success = false;
						break;
					}

					buffer.Append(input[i]);
					hasSeparator = true;
					continue;
				}

				if (input[i] == '.')
				{
					if (hasDecimal)
					{
						success = false;
						break;
					}

					buffer.Append(input[i]);
					hasDecimal = true;
					continue;
				}

				if (char.IsLetter(input[i]))
				{
					success = false;
				}

				break;
			}

			if (isNegative)
			{
				buffer.Insert(0, '-');
			}

			if (hasSeparator)
			{
				buffer = buffer.Replace("_", "");
			}

			if (hasDecimal || typeof(T) == typeof(float32) || typeof(T) == typeof(float64))
			{
				if (float64.TryParse(buffer.ToString(), out var r))
				{
					if ((typeof(T) == typeof(float32) && r is >= float32.MinValue and <= float32.MaxValue) ||
					    (typeof(T) == typeof(float32) && r is >= float64.MinValue and <= float64.MaxValue))
					{
						return T.Parse(buffer.ToString(), NumberStyles.Float | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
					}

					success = false;
					return T.Zero;
				}
			}

			var str = buffer.ToString();
			if (BigInteger.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
			{
				if (IsValidIntegerType<T>(result))
				{
					success = true;
					return T.Parse(str, NumberStyles.Any, CultureInfo.InvariantCulture);
				}
			}

			success = false;
			return T.Zero;
		}
		catch (Exception _)
		{
			success = false;
			return T.Zero;
		}
	}

	private static bool IsValidIntegerType<T>(BigInteger result) where T : struct, INumber<T>
	{
		return (typeof(T) == typeof(int8) && result >= int8.MinValue && result <= int8.MaxValue) ||
			(typeof(T) == typeof(uint8) && result >= uint8.MinValue && result <= uint8.MaxValue) ||
			(typeof(T) == typeof(int16) && result >= int16.MinValue && result <= int16.MaxValue) ||
			(typeof(T) == typeof(uint16) && result >= uint16.MinValue && result <= uint16.MaxValue) ||
			(typeof(T) == typeof(int32) && result >= int32.MinValue && result <= int32.MaxValue) ||
			(typeof(T) == typeof(uint32) && result >= uint32.MinValue && result <= uint32.MaxValue) ||
			(typeof(T) == typeof(int64) && result >= int64.MinValue && result <= int64.MaxValue) ||
			(typeof(T) == typeof(uint64) && result >= uint64.MinValue && result <= uint64.MaxValue) ||
			(typeof(T) == typeof(int128) && result >= int128.MinValue && result <= int128.MaxValue) ||
			(typeof(T) == typeof(uint128) && result >= uint128.MinValue && result <= uint128.MaxValue);
		
	}
}