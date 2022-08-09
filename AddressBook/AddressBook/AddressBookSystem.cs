using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBookSystem
    {
        public Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();
        public void AddAddressBook()
        {
            AddressBook addressBook = new AddressBook();
            addressBook.AddMultipleContact();
            Console.WriteLine("enter the addressbook name");
            string addressName = Convert.ToString(Console.ReadLine());
            addressBooks.Add(addressName.ToLower(), addressBook);

        }
    }
}
