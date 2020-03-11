using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaAdressBook
{
    public class Address
    {
        public string Adress;
        public int AddressId;
        public EnumAddressTypes AddressType;

        public override string ToString()
        {
              return Adress;
        }
    }
}
