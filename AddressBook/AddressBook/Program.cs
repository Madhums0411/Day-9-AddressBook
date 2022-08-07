using AddressBookProblem;

Console.WriteLine("Welcome to Address Book problem");

AddressBook address = new AddressBook();
Console.WriteLine();
string command = "";

while (command != "exit")
{
    Console.Clear();
    Console.WriteLine("Please enter a command: ");
    command = Console.ReadLine().ToLower();

    switch (command)
    {
        case "add":
            address.AddPerson();
            break;
        case "edit":
            address.EditContact();
            break;
    }
}