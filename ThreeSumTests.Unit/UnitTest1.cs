
using NUnit.Framework;
using ThreeSumFast;

namespace ThreeSumTests.Unit
{
    [TestFixture]
    public class TestThreeSum
    {
        [Test]
        public void ShouldReturnTheIndexOfGivenNumber()
        {
            int[] a = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 22 };

            BinarySearch bs = new BinarySearch();

            var sut = bs.Rank(a, 8);

            Assert.AreEqual(3,sut);
        }

        [Test]
        public void ShouldReturnCountOfTwoSum()
        {
            int[] a = { 2, 4, 6, 8, 10, 12, 14, 16, 18, -2 };

            TwoSum bs = new TwoSum();

            var sut = bs.Count(a);

            Assert.AreEqual(1,sut);
        }
    }
}
