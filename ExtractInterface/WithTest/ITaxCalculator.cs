using System;

namespace Salary
{
    public interface ITaxCalculator
    {
        decimal Calculate(decimal grossPay);
    }
}
