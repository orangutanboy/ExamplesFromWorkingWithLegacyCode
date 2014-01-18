using System.Net;
using System.Text;

namespace Salary
{
    public class TaxCalculator : Salary.ITaxCalculator
    {
        public decimal Calculate(decimal grossPay)
        {
            var webrequest = HttpWebRequest.Create("http://server/paycalculation/tax?amount=" + grossPay);
            var webResponse = (HttpWebResponse)webrequest.GetResponse();
            var responseStream = webResponse.GetResponseStream();
            var buffer = new byte[responseStream.Length];
            responseStream.Read(buffer, 0, buffer.Length);
            var responseString = new string(Encoding.UTF8.GetChars(buffer));
            return decimal.Parse(responseString);
        }
    }
}
