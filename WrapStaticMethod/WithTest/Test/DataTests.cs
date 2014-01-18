using NUnit.Framework;

namespace Data.Test
{
    [TestFixture]
    public class DataTests
    {
        [Test]
        public void Test()
        {
            var data = new FakeData("type");
            data.GetSql("code", "gdr", "filtertype", true);
        }
    }

    public class FakeData : Data
    {
        public FakeData(string type)
            : base(type)
        {
        }

        protected override string GetSingleResult(string sql)
        {
            return "";
        }
    }
}