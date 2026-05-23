using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public abstract class UserAccount
    {
        protected string full_name;
        protected string user_name;
        protected string user_password;
        
        public UserAccount(string name, string uName, string password)
        {
            full_name= name;
            user_name= uName; 
            user_password= password;
        }

        public abstract bool validateLogin(string uNmae, string password);

        public string getFullname()
        {
            return full_name;
        }
    }
}
