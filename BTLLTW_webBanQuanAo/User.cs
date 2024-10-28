using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLLTW_webBanQuanAo
{
    public class User
    {
        private string username, password;
        private string role;
        private int id;

        public User(int id, string taikhoan, string matkhau, string role)
        {

            this.username = taikhoan;
            this.password = matkhau;
            this.role = role;
            this.id = id;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Taikhoan
        {
            get => username;
            set => username = value;
        }

        public string Matkhau
        {
            get => password;
            set => password = value;
        }

        public string Role
        {
            get => role;
            set => role = value;
        }
    }
}