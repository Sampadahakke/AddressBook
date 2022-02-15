using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBooks
    {
        public List<Details> AddressList = new List<Details>();
        public void AddContacs(Details details)
        {
            AddressList.Add(details);
        }
        public void Display()
        {
            foreach ( var details in AddressList)
            {
                Console.WriteLine("\nFirstname: " + details.FirstName + "\nLastname: " + details.LastName + "\nAddress: " + details.Address + "\nCity: " + details.City + "\nState: " + details.State + "\nZip: " + details.Zip + "\nPhonenumber: " + details.PhoneNumber + "\nEmailId: " + details.EmailId);
            }
        }
    }
}
