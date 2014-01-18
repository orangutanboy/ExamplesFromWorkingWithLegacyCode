using ReportsLib;
using System.Text;

namespace Reports
{
    public class Statement
    {
        public string GetStatement(INameAndAddressProvider nameAndAddressProvider)
        {
            var report = new StringBuilder(nameAndAddressProvider.GetNameAndAddress());
            report.Append("Add something here");
            return report.ToString();
        }
    }
}
