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
        return (reader.ReadLine() ?? string.Empty).Trim();
    }
    
    /// <summary>
    /// Reads a number from <see cref="TextReader"/>, most commonly for reading numbers from the console, with an optional output message for when using the Console
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="message"></param>
    /// <param name="success"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>The parsed number, if success is false the number will be 0 for null safety</returns>
    public static T ReadNumber<T>(this TextReader reader, out bool success, string message = "") where T : struct, INumber<T>
    {
        Console.Out.Write(message);
        return Parser.Parse<T>(reader.GetLine(), out success);
    }

    /// <summary>
    /// Reads a number from <see cref="TextReader"/>, most commonly for reading numbers from the console, with an optional output message for when using the Console
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="message"></param>
    /// <param name="result"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>true if parsing was successful, otherwise false</returns>
    public static bool TryReadNumber<T>(this TextReader reader, out T result, string message = "") where T : struct, INumber<T>
    {
        if (!string.IsNullOrWhiteSpace(message))
        {
            Console.Out.Write(message);
        }
        
        result = Parser.Parse<T>(reader.GetLine(), out var success);
        return success;
    }

    public static DateTime ReadDateTime(this TextReader reader)
    {
        return DateTime.TryParse(reader.ReadLine() ?? "", out var date) ? date : DateTime.Now;
    }
    
    /// <summary>
    /// Reads/Parses a number from the given input
    /// </summary>
    /// <param name="input"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>null if parsing failed, otherwise true</returns>
    public static T? GetNumber<T>(this string input) where T : struct, INumber<T>
    {
        var value = Parser.Parse<T>(input, out var success);
        if (success)
        {
            return value;
        }

        return null;
    }
    
    /// <summary>
    /// Attempts to parse a number from the given input
    /// </summary>
    /// <param name="input"></param>
    /// <param name="result"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>true if successful, otherwise false</returns>
    public static bool TryGetNumber<T>(this string input, out T result) where T : struct, INumber<T>
    {
        result = Parser.Parse<T>(input, out var success);
        return success;
    }
}