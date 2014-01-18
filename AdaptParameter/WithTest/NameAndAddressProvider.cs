using ReportsLib;

namespace Reports
{
    public class NameAndAddressProvider : Reports.INameAndAddressProvider
    {
        NameAndAddress _nameAndAddress;
        
        public NameAndAddressProvider(NameAndAddress nameAndAddress)
        {
            _nameAndAddress = nameAndAddress;
        }

        public string GetNameAndAddress()
        {
            return _nameAndAddress.GetNameAndAddress();
        }
    }
}
