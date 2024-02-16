using System;
using System.IO;
using System.Numerics;
using JetBrains.Annotations;

namespace Simput;

[PublicAPI]
public static class Reader
{
    private static string GetLine(this TextReader reader)
    {
        return reader.ReadLine() ?? string.Empty;
    }
    
    public static T ReadNumber<T>(this TextReader reader, string message, out bool success) where T : struct, INumber<T>
    {
        Console.Out.Write(message);
        return Parser.Parse<T>(reader.GetLine(), out success);
    }

    public static bool TryReadNumber<T>(this TextReader reader, string message, out T result) where T : struct, INumber<T>
    {
        Console.Out.Write(message);
        result = Parser.Parse<T>(reader.GetLine(), out var success);
        return success;
    }
    
    public static T ReadNumber<T>(this TextReader reader, out bool success) where T : struct, INumber<T>
    {
        return Parser.Parse<T>(reader.GetLine(), out success);
    }

    public static bool TryReadNumber<T>(this TextReader reader, out T result) where T : struct, INumber<T>
    {
        result = Parser.Parse<T>(reader.GetLine(), out var success);
        return success;
    }

    public static DateTime ReadDateTime(this TextReader reader)
    {
        return DateTime.TryParse(reader.ReadLine() ?? "", out var date) ? date : DateTime.Now;
    }
    
    public static T Read<T>(this string input) where T : struct, INumber<T>
    {
        return Parser.Parse<T>(input, out _);
    }
    
    public static T Read<T>(this string input, out bool success) where T : struct, INumber<T>
    {
        return Parser.Parse<T>(input, out success);
    }
    
    public static bool TryRead<T>(this string input, out T result) where T : struct, INumber<T>
    {
        result = Parser.Parse<T>(input, out var success);
        return success;
    }
}