// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************* Address Book Using Collection *****************");
using AddressBook_UsingCollection;
Console.Write("Select Number:\n1)AddContacts");
int option = Convert.ToInt32(Console.ReadLine());
ContactDetails contactDetails = new ContactDetails();

switch (option)
{

    case 1:
        contactDetails.Add();
        contactDetails.Print();
        break;

    default:
        Console.WriteLine("Invalid Option");
        break;

}
