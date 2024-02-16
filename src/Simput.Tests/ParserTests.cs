using Xunit;

namespace Simput.Tests;

public class SimpleInputsParsing
{
    [Theory]
    [InlineData("1234")]
    [InlineData("-1")]
    [InlineData("-1044324")]
    [InlineData("343242")]
    public void Parser_Int(string input)
    {
        input.Read<int>(out var success);
        Assert.True(success);
    }
    
    [Theory]
    [InlineData("343242")]
    [InlineData("343242.0231")]
    public void Parser_FloatNoLetters(string input)
    {
        input.Read<float>(out var success);
        Assert.True(success);
    }
    
    [Theory]
    [InlineData("34asda3242")]
    [InlineData("343_242.0f64")]
    [InlineData("-1044324.0f32")]
    [InlineData("-1044324.0f")]
    public void Parser_FloatLetters(string input)
    {
        input.Read<float>(out var success);
        Assert.False(success);
    } 
    
    [Theory]
    [InlineData("34_3242_")]
    [InlineData("3___43242.064")]
    [InlineData("-10_44_324.032")]
    [InlineData("-10__44324.0")]
    public void Parser_FloatMultipleSeparators(string input)
    {
        input.Read<float>(out var success);
        Assert.False(success);
    } 
    
    [Theory]
    [InlineData("_343242")]
    [InlineData("__343242.064")]
    [InlineData("-_1044324.032")]
    [InlineData("-_1044324.0")]
    [InlineData("_-1044324.0")]
    [InlineData("_-_1044324.0")]
    public void Parser_FloatStartingSeparators(string input)
    {
        input.Read<float>(out var success);
        Assert.False(success);
    } 
}