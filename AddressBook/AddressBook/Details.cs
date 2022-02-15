using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Details
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }



        public void Display()
        {
            Console.WriteLine("First Name = " + this.FirstName);
            Console.WriteLine("Last Name = " + this.LastName);
            Console.WriteLine("Address = " + this.Address);
            Console.WriteLine("City = " + this.City);
            Console.WriteLine("State = " + this.State);
            Console.WriteLine("Zip = " + this.Zip);
            Console.WriteLine("Phone Number = " + this.PhoneNumber);
            Console.WriteLine("Email Id = " + this.EmailId);

        }


    }

    
}
    
