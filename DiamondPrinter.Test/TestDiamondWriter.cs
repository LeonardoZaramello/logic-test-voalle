using Xunit;
using System.IO;
using System;
using DiamondPrinter;
using FluentAssertions;

namespace DiamondPrinter.Test;

[Collection("Sequential")]
public class UnitTest1
{
    [Theory(DisplayName = "Must return Greeting function")]
    [InlineData()]
    public void TestGreetingFunction()
    {
        var diamond = new DiamondWriter();

        using var NewOutput = new StringWriter();
        Console.SetOut(NewOutput);

        diamond.greeting();

        NewOutput.ToString().Trim().Should().Be("Welcome to Diamond Printer!!");
    }

    [Theory(DisplayName = "Alphabet must contain all Upper case letters")]
    [InlineData(new object[] { new char[] { 'A', 'B', 'C', 'D','E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'}})]
    public void TestGetAlphabetUpperCase(char[] entrys)
    {
        var diamond = new DiamondWriter();

        diamond.getAlphabetUpperCase();

        diamond.alphabet.Should().Contain(entrys);
        diamond.alphabet.Length.Should().Be(26);
    }

    [Theory(DisplayName = "Alphabet must contain all Lower case letters")]
    [InlineData(new object[] { new char[] { 'a', 'b', 'c', 'd','e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'}})]
    public void TestGetAlphabetLowerCase(char[] entrys)
    {
        var diamond = new DiamondWriter();

        diamond.getAlphabetLowerCase();

        diamond.alphabet.Should().Contain(entrys);
        diamond.alphabet.Length.Should().Be(26);
    }

    [Theory(DisplayName = "Must return the index of the user input")]
    [InlineData('D', 3)]
    [InlineData('J', 9)]
    public void TestGetDiamondSizeUpperCase(char letter, int expectedValue)
    {
        var diamond = new DiamondWriter
        {
            choosedLetter = letter
        };

        diamond.getAlphabetUpperCase();
        diamond.getDiamondSize();

        diamond.diamondSize.Should().Be(expectedValue);
    }

    [Theory(DisplayName = "Must return the index of the user input")]
    [InlineData('d', 3)]
    [InlineData('j', 9)]
    public void TestGetDiamondSizeLowerCase(char letter, int expectedValue)
    {
        var diamond = new DiamondWriter
        {
            choosedLetter = letter
        };

        diamond.getAlphabetLowerCase();
        diamond.getDiamondSize();

        diamond.diamondSize.Should().Be(expectedValue);
    }
}