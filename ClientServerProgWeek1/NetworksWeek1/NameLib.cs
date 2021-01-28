using System;
using System.Collections.Generic;
using System.Text;

namespace ClientServerProgWeek1.NetworksWeek1
{
    class NameLib
    {
        public bool IsLibClass;

        public static string FullName(string name, string lastName)
        {
            return name + " " + lastName;
        }
    }
}
