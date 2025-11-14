using MauiApp.Service;

namespace TestProject;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var service = new MyService();
        service.HelloWorld();
        Assert.Pass();
    }
}
