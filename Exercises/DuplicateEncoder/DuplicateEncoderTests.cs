using NUnit.Framework;

namespace DotNetKatas.Exercises.DuplicateEncoder;

public class DuplicateEncoderTests
{
    [Test]
    public void Test_din()
    {
        DuplicateEncoder duplicateEncoder = new();
        var input = "din";
        var result = duplicateEncoder.Get(input);
        Assert.AreEqual("(((", result);
    }

    [Test]
    public void Test_recede()
    {
        DuplicateEncoder duplicateEncoder = new();
        var input = "recede";
        var result = duplicateEncoder.Get(input);
        Assert.AreEqual("()()()", result);
    }

    [Test]
    public void Test_Success()
    {
        DuplicateEncoder duplicateEncoder = new();
        var input = "Success";
        var result = duplicateEncoder.Get(input);
        Assert.AreEqual(")())())", result);
    }

    [Test]
    public void Test_symbols()
    {
        DuplicateEncoder duplicateEncoder = new();
        var input = "(( @";
        var result = duplicateEncoder.Get(input);
        Assert.AreEqual("))((", result);
    }

    [Test]
    public void Test_empty()
    {
        DuplicateEncoder duplicateEncoder = new();
        string input = string.Empty;
        var result = duplicateEncoder.Get(input);
        Assert.AreEqual(string.Empty, result);
    }
}