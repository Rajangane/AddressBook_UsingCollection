﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UsingCollection
{
    public class ContactDetails
    {
        //list declaration to store the personal details
        List<Contacts> listcontacts = new List<Contacts>();
        Dictionary<string, Contacts> dic = new Dictionary<string, Contacts>();

        public void Add()//add method 
        {
            Console.WriteLine("Enter Personal Details : ");
            Console.Write("First Name : ");
            string first_name = Console.ReadLine();
            Console.Write("Last Name : ");
            string last_name = Console.ReadLine();
            Console.Write("Address : ");
            string address = Console.ReadLine();
            Console.Write("City : ");
            string city = Console.ReadLine();
            Console.Write("State : ");
            string state = Console.ReadLine();
            Console.Write("Zip Code : ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone No. : ");
            int phone_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("E-mail ID : ");
            string email = Console.ReadLine();

            //adding the details in list
            listcontacts.Add(new Contacts()
            {
                first_name = first_name,
                last_name = last_name,
                address = address,
                city = city,
                state = state,
                zip = zip,
                phone_no = phone_no,
                email = email
            });

        }
        public void Print()//Print method 
        {
            for (int i = 0; i < listcontacts.Count; i++)
            {
                Contacts contact = listcontacts[i];

                if (!dic.ContainsKey(contact.first_name))//condition to check whether the key is present or not
                {
                    dic.Add(contact.first_name, contact);//if not present add into the addressbook
                }
                else
                {
                    Console.WriteLine(" Name {0} is present", contact.first_name);
                }
            }
            foreach (var i in dic)
            {
                Console.WriteLine("First Name : " + i.Key);
                Console.WriteLine("Last Name : " + i.Value.last_name);
                Console.WriteLine("Address : " + i.Value.address);
                Console.WriteLine("City Name : " + i.Value.city);
                Console.WriteLine("State Name : " + i.Value.state);
                Console.WriteLine("Zip Code : " + i.Value.zip);
                Console.WriteLine("Phone No. : " + i.Value.phone_no);
                Console.WriteLine("Email ID : " + i.Value.email);
                Console.WriteLine("\n");
            }
        }
    }
}
