namespace Salary
{
    public class PayCalculator
    {
        public decimal CalculateTakeHomePay(decimal grossPay, decimal natIns)
        {
            var taxCalculator = new TaxCalculator();
            var tax = taxCalculator.Calculate(grossPay);
            return grossPay - (tax + natIns);
        }
    }
}