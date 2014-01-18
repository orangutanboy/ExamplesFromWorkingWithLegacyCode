using NUnit.Framework;

namespace Data.Test
{
    [TestFixture]
    public class DataTests
    {
        [Test]
        public void Test()
        {
            DatabaseWrapper.GetSingleResult = sql => "";
            var data = new Data("type");
            data.GetSql("m", "r", "o", true);
        }
    }
}

