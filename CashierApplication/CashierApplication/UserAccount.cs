using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    internal abstract class UserAccount
    {
        public string full_name;
        public string user_name;
        public string user_password;

        public UserAccount (string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }
        public abstract bool validateLogin(string uName, string password);

        public string getFullName()
        {
            return this.full_name;
        }
    }
}
