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
        public List<Contact> addressBook = new List<Contact>();
        public void AddNewContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter First name");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last name");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City name");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State name");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Zip code");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter Phone number");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();

            addressBook.Add(contact);

        }
        public void Display()
        {
            foreach (Contact contact in addressBook)
            {
                Console.WriteLine("First Name:" + contact.FirstName);
                Console.WriteLine("Last Name:" + contact.LastName);
                Console.WriteLine("Adress:" + contact.Address);
                Console.WriteLine("City:" + contact.City);
                Console.WriteLine("State:" + contact.State);
                Console.WriteLine("Zip:" + contact.Zip);
                Console.WriteLine("Phone Number:" + contact.PhoneNumber);
                Console.WriteLine("Email:" + contact.Email);

            }
        }
    }
}
