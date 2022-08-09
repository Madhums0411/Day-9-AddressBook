using AddressBookProblem;

Console.WriteLine("Welcome to Address Book problem");

AddressBookSystem addressBookSystem = new AddressBookSystem();
string command1 = "";


    while (command1 != "exit")
    {
        Console.WriteLine("enter the option: 1.Add AdressBook 2.Edit AddressBook 3.Remove AddressBook");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
            addressBookSystem.AddAddressBook();
                break;
            case 2:
                Console.WriteLine("enter the addressbook name you want to edit");
                string addressBookName = Console.ReadLine();


                if (addressBookSystem.addressBooks.ContainsKey(addressBookName.ToLower()))
                {


                    string command = "";

                    while (command != "exit")
                    {

                        Console.WriteLine("Please enter a command add,edit,remove,display,multipleperson: ");
                        command = Console.ReadLine().ToLower();


                        switch (command)
                        {
                            case "add":


                                addressBookSystem.addressBooks[addressBookName.ToLower()].AddPerson();
                                break;
                            case "edit":
                                addressBookSystem.addressBooks[addressBookName.ToLower()].EditContact();
                                break;
                            case "remove":
                                addressBookSystem.addressBooks[addressBookName.ToLower()].RemoveContact();
                                break;
                            case "display":
                                addressBookSystem.addressBooks[addressBookName.ToLower()].Display();
                                break;
                            case "multipleperson":
                                addressBookSystem.addressBooks[addressBookName.ToLower()].AddMultipleContact();
                                break;
                            default:
                                command = "exit";
                                break;
                        }
                    }
                }
                break;
            default:
                command1 = "exit";
                break;





        }

    }