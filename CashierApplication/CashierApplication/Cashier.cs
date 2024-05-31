using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    internal class Cashier : UserAccount
    {
        private string departmanent;

        public Cashier(string name, string department, string uName, string password) : base (name, uName, password)
        {
            this.full_name = name;
            this.departmanent = department;
            this.user_name = uName;
            this.user_password = password;
        }
        public override bool validateLogin (string username, string password)
        {
           if(user_name.Equals("Cashier101") && password.Equals("12345"))
            {
                return true;
            }
           else
            {
                return false;
            }
        }

        public string getDepartment()
        {
            return departmanent;
        }

    }
}
