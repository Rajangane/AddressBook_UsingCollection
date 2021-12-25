// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************* Address Book Using Collection *****************");
//Console.WriteLine("************** Address Book Using Collection ***************")
using AddressBook_UsingCollection;
Console.Write("Select Number:\n1)AddContacts\n2)EditContacts");
int option = Convert.ToInt32(Console.ReadLine());
ContactDetails contactDetails = new ContactDetails();

switch (option)
{

    case 1:
        contactDetails.Add();
        contactDetails.Print();
        break;
    case 2:
        Console.WriteLine(" contact which you want to edit :-");
        Console.WriteLine("Edit Sequence");
        Console.WriteLine("First name,Last name,Address, City, State");
        string name = Console.ReadLine();
        string first = Console.ReadLine();
        string last = Console.ReadLine();
        string add = Console.ReadLine();
        string cityN = Console.ReadLine();
        string stateN = Console.ReadLine();

        contactDetails.Edit(name, first, last, add, cityN, stateN);//to edit contact details
        contactDetails.Print();
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;

}
