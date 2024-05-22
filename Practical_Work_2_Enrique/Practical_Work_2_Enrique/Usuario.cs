using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_2_Enrique
{
    public class Usuario
    {
        private string name;
        private string userName;
        private string email;
        private string password;

        public Usuario(string name, string userName, string email, string password)
        {
            this.name = name;
            this.userName = userName;
            this.email = email;
            this.password = password;
        }


        public string Print()
        {
            return this.name + ";" + this.userName + ";" + this.email + ";" + this.password;
        }

        public string GetName() 
        { 
            return this.name; 
        }

        public string GetUName()
        {
            return this.userName;
        }

        public void SetPassword(string new_passwd)
        {
            this.password = new_passwd;
        }
    }
}
