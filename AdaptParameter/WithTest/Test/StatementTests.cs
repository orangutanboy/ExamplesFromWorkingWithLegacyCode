using NUnit.Framework;
using Rhino.Mocks;

namespace Reports.Test
{
    [TestFixture]
    public class StatementTests
    {
        [Test]
        public void Test()
        {
            var nameAndAddressProvider = MockRepository.GenerateMock<INameAndAddressProvider>();
            nameAndAddressProvider.Stub(n => n.GetNameAndAddress()).Return("name,address1,address2:");
            var statement = new Statement();
            Assert.That(statement.GetStatement(nameAndAddressProvider), Is.EqualTo("name,address1,address2:Add something here"));
        }
    }
}
