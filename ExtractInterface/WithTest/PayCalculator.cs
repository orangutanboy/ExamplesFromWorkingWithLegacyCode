namespace Salary
{
    public class PayCalculator
    {
        public decimal CalculateTakeHomePay(decimal grossPay, decimal natIns)
        {
            var taxCalculator = new TaxCalculator();
            return CalculateTakeHomePay(grossPay, natIns, taxCalculator);           
        }

        public decimal CalculateTakeHomePay(decimal grossPay, decimal natIns, ITaxCalculator taxCalculator)
        {
            var tax = taxCalculator.Calculate(grossPay);
            return grossPay - (tax + natIns);
        }
    }
}