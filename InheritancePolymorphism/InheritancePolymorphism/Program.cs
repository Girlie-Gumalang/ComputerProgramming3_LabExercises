using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public abstract class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public bool verifyLogin(string id, string pass)
        {
            return user_id.Equals(id) && user_password.Equals(pass);
        }

        public abstract void updatePassword(string newPassword);
    }

    public class Administrator : User
    {

        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
        }
        public override void updatePassword(string newPassword)
        {
            this.user_password = newPassword;

        }
        public void updateAdminName(string name)
        {
            this.admin_name = name;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

}