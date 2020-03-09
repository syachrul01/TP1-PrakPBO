using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Login
    {
        public string user { get; set; }
        public string pass { get; set; }

        public Login(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public Login()
        {

        }
    }
}
