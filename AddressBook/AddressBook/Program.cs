using AddressBookProblem;

Console.WriteLine("Welcome to Address Book problem");

AddressBook address = new AddressBook();
Console.WriteLine();
string command = "";

while (command != "exit")
{
    Console.Clear();
    Console.WriteLine("Please enter a command add,edit,remove,display,multipleperson: ");
    command = Console.ReadLine().ToLower();

    switch (command)
    {
        case "add":
            address.AddPerson();
            break;
        case "edit":
            address.EditContact();
            break;
        case "remove":
            address.RemoveContact();
            break;
        case "display":
            address.Display();
            break;
        case "multipleperson":
            address.AddMultipleContact();
            break;
    }
}