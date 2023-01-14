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
}