using ReportsLib;
using System.Text;

namespace Reports
{
    public class Statement
    {
        public string GetStatement(NameAndAddress nameAndAddress)
        {
            var report = new StringBuilder(nameAndAddress.GetNameAndAddress());
            report.Append("Add something here");
            return report.ToString();
        }
    }
}
