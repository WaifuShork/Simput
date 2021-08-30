namespace SimpleInputs.Extensions
{
	using System.ComponentModel;

	public static class GenericExtensions
	{
		public static bool GenericTryParse<T>(this string input, out T value)
		{
			var converter = TypeDescriptor.GetConverter(typeof(T));

			if (converter.IsValid(input))
			{
				value = (T)converter.ConvertFromString(input);
				return true;
			}
			
			value = default;
			return false;
		}
	}
}