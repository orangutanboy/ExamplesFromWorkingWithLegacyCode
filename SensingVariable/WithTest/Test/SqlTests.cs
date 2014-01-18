using NUnit.Framework;
using Rhino.Mocks;

namespace Database.Test
{
    [TestFixture]
    public class SqlTests
    {
        [Test]
        public void Test()
        {
            var sql = new Sql();
            var databaseWrapper = MockRepository.GenerateMock<IDatabaseWrapper>();
            sql.UpdateTable1("T", new[] { "rr", "tt" }, databaseWrapper);
            Assert.That(sql.ExecutedSql, Is.EqualTo("update table1, T set t1.name = T.namewhere t1.id=rr and tt"));
        }
    }
}