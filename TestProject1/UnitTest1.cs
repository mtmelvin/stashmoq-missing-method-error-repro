using Stashbox.Mocking.Moq;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestInitialize]
    public void TestInitialize()
    {
        // StashMoq.Create throws with Stashbox 5.16.0 but works with 5.15.0
        //  System.MissingMethodException: 'Method not found: 'Void Stashbox.IStashboxContainer.RegisterResolver(Stashbox.Resolution.IResolver)'.'

        using var stash = StashMoq.Create();
    }

    [TestMethod]
    public void TestMethod1()
    {
        Assert.IsTrue(true);
    }
}