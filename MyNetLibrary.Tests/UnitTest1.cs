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
        try
        {
            RustInterop.i_panic();
        }
        catch (Exception ex)
        {
            Assert.Pass("Caught an exception: " + ex.Message);
        }
    }

    [Test]
    public void TestIsPanicWithUnwindCaught()
    {
        RustInterop.i_panic_with_unwind();
        Assert.Pass("Panic with unwind was caught successfully.");
    }
}