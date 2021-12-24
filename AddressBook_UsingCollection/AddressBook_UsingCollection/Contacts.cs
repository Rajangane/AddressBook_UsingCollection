using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UsingCollection
{
    public class Contacts
    {
        //Encapsulation
        public string first_name { get; set; } //property
        public string last_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public long phone_no { get; set; }
        public string email { get; set; }
    }
}
