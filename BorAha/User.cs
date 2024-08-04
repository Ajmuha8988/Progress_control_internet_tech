using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BorAha
{
    class User
    {
        public int ID { get; set; }
        private string Fullname, Password, Email;
        
        
        public string fullname
        {
            get { return Fullname; }
            set { Fullname = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public User() { }

        public User(string Fullname, string Email, string Password)
        {
            this.Fullname = Fullname;
            this.Password = Password;
            this.Email = Email;
        }


        public override string ToString()
        {
            return Fullname;
        }
    }
}
