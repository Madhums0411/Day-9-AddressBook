using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }

    }
    public class AddressBook
    {
        public List<Contact> People = new List<Contact>();

        public void AddPerson()
        {
            Contact person = new Contact();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            foreach (Contact contact in People)
            {
                if (contact.FirstName.ToLower() == person.FirstName.ToLower())
                {
                    Console.WriteLine("person already exist");
                    return;
                }
            }
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter city name: ");
            person.City = Console.ReadLine();
            Console.Write("Enter State name: ");
            person.State = Console.ReadLine();
            Console.Write("Enter zip number: ");
            person.Zip = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();
            Console.Write("Enter Address 1: ");
            person.Address = Console.ReadLine();
            People.Add(person);
        }
        public void EditContact()
        {
            Console.WriteLine("enter the first name you want to edit");
            string firstname = Console.ReadLine();
            foreach (Contact contact in People)
            {
                if (contact.FirstName.ToLower() == firstname.ToLower())
                {
                    Console.WriteLine("Enter which information you want to change");
                    Console.WriteLine("Enter 1 for edit last name,2 for city,3 for State,4 for Zip,5 for Phone number , 6 for Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the lastname");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the city");
                            contact.City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the State");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the zip");
                            contact.Zip = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the Phone number");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the Email");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                    }
                    return;
                }
            }
            Console.WriteLine("no contact with this firstname");
        }
    }
}

