namespace Collections;
public class CollectionTests
{
    [Test]
    public void Test_Collection_EmptyConstructor()
    {
        var nums = new Collection<int>();
        Assert.That(nums.ToString(), Is.EqualTo("[]"));
    }

    [Test]
    public void Test_Collection_ConstructorSingleItem()
    {
        var nums = new Collection<int>(5);
        Assert.That(nums[0], Is.EqualTo(5));
    }
}