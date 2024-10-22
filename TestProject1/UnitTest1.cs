namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var class1 = new ClassLibrary1.Class1();
        Assert.Equal(3, class1.Add(1, 2));
    }
}