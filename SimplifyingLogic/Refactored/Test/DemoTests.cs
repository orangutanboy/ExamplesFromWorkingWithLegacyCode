using NUnit.Framework;

namespace Demo.Test
{
    [TestFixture]
    public class DemoTests
    {
        [TestCase(true, true, true, 10)]
        [TestCase(true, true, false, 6)]
        [TestCase(true, false, true, 18)]
        [TestCase(true, false, false, 4)]
        [TestCase(false, false, false, 4)]
        [TestCase(false, false, true, 14)]
        [TestCase(false, true, false, 1)]
        [TestCase(false, true, true, 10)]
        public void GetRatingLogicTest(bool male, bool ginger, bool hasGlasses, int expected)
        {
            Assert.That(Ratings.GetRating(male, ginger, hasGlasses), Is.EqualTo(expected));
        }
    }
}
