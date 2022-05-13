using NUnit.Framework;

namespace DotNetKatas.Exercises.FizzBuzz;

public class FizzBuzzTests
{
    [Test]
    public void Test_FizzBuzz_1()
    {
        FizzBuzz fizzBuzz = new();
        var i = 1;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("1", result);
    }

    [Test]
    public void Test_FizzBuzz_2()
    {
        FizzBuzz fizzBuzz = new();
        var i = 2;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("2", result);
    }

    [Test]
    public void Test_FizzBuzz_3()
    {
        FizzBuzz fizzBuzz = new();
        var i = 3;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("Fizz", result);
    }

    [Test]
    public void Test_FizzBuzz_5()
    {
        FizzBuzz fizzBuzz = new();
        var i = 5;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("Buzz", result);
    }

    [Test]
    public void Test_FizzBuzz_8()
    {
        FizzBuzz fizzBuzz = new();
        var i = 8;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("8", result);
    }

    [Test]
    public void Test_FizzBuzz_9()
    {
        FizzBuzz fizzBuzz = new();
        var i = 9;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("Fizz", result);
    }

    [Test]
    public void Test_FizzBuzz_10()
    {
        FizzBuzz fizzBuzz = new();
        var i = 10;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("Buzz", result);
    }

    [Test]
    public void Test_FizzBuzz_15()
    {
        FizzBuzz fizzBuzz = new();
        var i = 15;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("FizzBuzz", result);
    }

    [Test]
    public void Test_FizzBuzz_30()
    {
        FizzBuzz fizzBuzz = new();
        var i = 30;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("FizzBuzz", result);
    }

    [Test]
    public void Test_FizzBuzz_81()
    {
        FizzBuzz fizzBuzz = new();
        var i = 81;
        var result = fizzBuzz.GetString(i);
        Assert.AreEqual("Fizz", result);
    }

    [Test]
    public void Test_FizzBuzz_To_100()
    {
        FizzBuzz fizzBuzz = new();
        var i = 100;
        var result = fizzBuzz.GetFizzBuzz(i);
        Assert.AreEqual(100, result.Count);
        Assert.AreEqual("4", result[3]);
        Assert.AreEqual("FizzBuzz", result[74]);
    }

    [Test]
    public void Test_FizzBuzz_To_10000000()
    {
        FizzBuzz fizzBuzz = new();
        var i = 10000000;
        var result = fizzBuzz.GetFizzBuzz(i);
        Assert.AreEqual(10000000, result.Count);
        Assert.AreEqual("4", result[3]);
        Assert.AreEqual("FizzBuzz", result[981389]);
        Assert.AreEqual("Fizz", result[196310]);
    }
}