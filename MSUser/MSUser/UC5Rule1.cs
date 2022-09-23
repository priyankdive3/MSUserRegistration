using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSUser
{
    public class UC5Rule1
    {
        public string password;

        public UC5Rule1(string password)
        {
            this.password = password;
        }

        public string ValidatePassword()
        {
            var Character = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]).{8,}$");
            if (!Character.IsMatch(password))
            {
                Console.WriteLine("password should have minimum 8 characters");
                return null;
            }
            else
            {
                //Console.WriteLine("Password is valid");
                return password;
            }
        }
    }
}
