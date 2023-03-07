using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAn
{
    internal class Admin
    {
        public int idadmin;
        public string name;
        public string password;
        public Admin() { }
        public int IDadmin { get { return idadmin; } }

        public string Name
        {
            get { return name; }
        }

        public string Password
        { get { return password; } }

    }
}
