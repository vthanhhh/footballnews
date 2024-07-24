using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace footballnews
{
    public class taikhoan
    {
        string user;
        string password;

        public taikhoan() { }
        public taikhoan(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}