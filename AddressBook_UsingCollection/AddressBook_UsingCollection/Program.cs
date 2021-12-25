// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************* Address Book Using Collection *****************");
using AddressBook_UsingCollection;
ContactDetails contactDetails = new ContactDetails();
int count = 0;//counter to break the while loop

while (count == 0)
{
    Console.Write("Select Number:\n1)AddContacts\n2)PrintContactsn\n3)EditContacts\n4)DeleteContacts\n5)SearchContacts\n6)SearchContacts2");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {

        case 1:
            Console.WriteLine("Number of Contacts: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                contactDetails.Add();
            }
          break;
        case 2:
            contactDetails.Print();
            break;

        case 3:
            Console.WriteLine(" contact which you want to edit :");
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
        case 4:
            Console.WriteLine("Enter First Name To Delete:");
            string firstname = Console.ReadLine();
            contactDetails.Delete(firstname);//to delete the contact
            break;
        case 5:
            Console.Write("City Name : ");
            string cname = Console.ReadLine();

            Console.WriteLine("State Name : ");
            string sname = Console.ReadLine();
            contactDetails.SearchContact(cname, sname);
            break;
        case 6:

            Console.Write(" City Name : ");
            string city1 = Console.ReadLine();

            Console.WriteLine("State Name : ");
            string state1 = Console.ReadLine();
            contactDetails.SearchCityState(city1, state1);

            break;
        default:
            Console.WriteLine("Invalid Option");
            break;

    }

}