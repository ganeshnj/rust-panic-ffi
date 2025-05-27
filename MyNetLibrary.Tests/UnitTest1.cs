namespace MyNetLibrary.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void TestIsPanicCaught()
    {
        RustInterop.IsPanicCaught();
    }
}