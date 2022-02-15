using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBooks
    {
        //Creating Object Of Class
        Details details = new Details();
        //Creating List 
        public List<Details> AddressList = new List<Details>();
        public void AddContacs(Details details)
        {
            AddressList.Add(details);
        }

        //Creating Method For Editing Existing Contacts
        public void Editexistingcontact()
        {
            Console.WriteLine("Enter first name of person you want to edit");
            string name = Console.ReadLine();
            foreach (var details in AddressList)
            {
                if (details.FirstName == name)
                {
                    Console.WriteLine("Enter number : \n 1. First name \n 2. Last name \n 3. Address \n 4. City \n 5. State \n 6. Zip code \n 7. Phone Number \n 8. Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter new firstname");
                            string first = Console.ReadLine();
                            details.FirstName = first;
                            break;
                        case 2:
                            Console.WriteLine("Enter new lastname");
                            string last = Console.ReadLine();
                            details.LastName = last;
                            break;
                        case 3:
                            Console.WriteLine("Enter new address");
                            string address = Console.ReadLine();
                            details.Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter new city");
                            string city = Console.ReadLine();
                            details.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter new state");
                            string state = Console.ReadLine();
                            details.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter new zip");
                            string zip = Console.ReadLine();
                            details.Zip = zip;
                            break;
                        case 7:
                            Console.WriteLine("Enter new phonenumber");
                            string phone = Console.ReadLine();
                            details.PhoneNumber = phone;
                            break;
                        case 8:
                            Console.WriteLine("Enter new emailid");
                            string email = Console.ReadLine();
                            details.EmailId = email;    
                            break;

                        default:
                            break;
                    }
                    
                }
                
              
            }

        }
            //Display Of Contacts
            public void Display()
            {
                foreach (var details in AddressList)
                {
                    Console.WriteLine("\nFirstname: " + details.FirstName + "\nLastname: " + details.LastName + "\nAddress: " + details.Address + "\nCity: " + details.City + "\nState: " + details.State + "\nZip: " + details.Zip + "\nPhonenumber: " + details.PhoneNumber + "\nEmailId: " + details.EmailId);
                }
            }
        
    }
}
