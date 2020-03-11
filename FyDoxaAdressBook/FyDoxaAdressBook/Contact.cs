using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaAdressBook
{
    public class Contact
    {
        public int ContactId;
        public string ContactName;
        public  List<Address> Addresses;
        public  List<Phone> Phones;
        public  List<Email> Emails;

        public override string ToString()
        {
            return ContactName;
        }
    }
}
