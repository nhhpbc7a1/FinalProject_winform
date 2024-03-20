using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    class Account
    {
        public int userId;
        public string username;
        public string password;
        public Account() { }
        public Account(int userId, string username, string password)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
        }
    }
}
