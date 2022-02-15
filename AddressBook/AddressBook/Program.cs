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

            //Creating Object Of Details Class
            Details details = new Details();
            //Assigning Variable
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nEnter Number to Execute the Address book Program \n1. Create Details \n2. Exit");
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
                        details.Display();
                        break;

                    case 2:
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

