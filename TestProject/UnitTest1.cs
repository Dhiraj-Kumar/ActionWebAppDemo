using CyberShop.Repository;
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
        CustomerRepository repo = new CustomerRepository();
        string result = repo.sayHello("John");
        Assert.AreEqual(result, "Hello John");
    }
}