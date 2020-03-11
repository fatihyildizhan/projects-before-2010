using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaAdressBook
{
    public class Phone
    {
        public int PhoneId;
        public string PhoneNumber;
        public EnumPhoneTypes PhoneType;

        public override string ToString()
        {
            return PhoneNumber;
        }
    }
}
