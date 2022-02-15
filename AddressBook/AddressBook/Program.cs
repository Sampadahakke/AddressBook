using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==========================================Welcome To Address Book==================================================");
            Console.ReadLine();

            //Creating Object Of AddressBooks
            AddressBooks address = new AddressBooks();
            //Creating Object Of Details Class
            Details details = new Details();
            //Assigning Variable
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nEnter Number to Execute the Address book Program \n1. Create Details \n2. Add Contacts \n3. Edit Contacts \n4. Delete Contacts \n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                //Using switch case to check options
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information : \nFirst Name, Last Name,Address,City,State, Zip, Phone Number and Email Id");
                        details.FirstName = Console.ReadLine();
                        details.LastName = Console.ReadLine();
                        details.Address = Console.ReadLine();
                        details.City = Console.ReadLine();
                        details.State = Console.ReadLine();
                        details.Zip = Console.ReadLine();
                        details.PhoneNumber = Console.ReadLine();
                        details.EmailId = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter the Contact Information : \nFirst Name, Last Name,Address,City,State, Zip, Phone Number and Email Id");
                        details.FirstName = Console.ReadLine();
                        details.LastName = Console.ReadLine();
                        details.Address = Console.ReadLine();
                        details.City = Console.ReadLine();
                        details.State = Console.ReadLine();
                        details.Zip = Console.ReadLine();
                        details.PhoneNumber = Console.ReadLine();
                        details.EmailId = Console.ReadLine();
                        address.AddContacs(details);
                        address.Display();
                        break;

                    case 3:
                        address.Editexistingcontact();
                        address.Display();
                        break;

                    case 4:
                        address.Deletecontact();
                        address.Display();
                        break;

                    case 5:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

            } 
        }
    }
}

