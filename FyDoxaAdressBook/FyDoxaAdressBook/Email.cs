using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaAdressBook
{
    public class Email
    {
        public string EmailAddress;
        public int EmailId;
        public EnumEmailTypes EmailType;

        public override string ToString()
        {
            return EmailAddress;
        }
    }
}
