using NUnit.Framework;
using Rhino.Mocks;

namespace Salary.Test
{
    [TestFixture]
    public class PayCalculatorTests
    {
        [Test]
        public void Test()
        {
            var taxCalculator = MockRepository.GenerateMock<ITaxCalculator>();
            taxCalculator.Stub(t => t.Calculate(40000)).Return(5000);
            var paycalculator = new PayCalculator();
            Assert.That( paycalculator.CalculateTakeHomePay(40000, 2000, taxCalculator), Is.EqualTo(33000));
        }
    }
}

