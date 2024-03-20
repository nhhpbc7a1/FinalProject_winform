﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    internal class User
    {
        public int userId;
        public string personalId;
        public string name;
        public DateOnly birthday;
        public string email;
        public string phone; 
        public string gender; 
        public string address; 
        public Image image = Properties.Resources.empty_avatar;
        public User() { }
        public User(string personalId, string name, DateOnly birthday, string email, string phone, string gender, string address)
        {
            this.personalId = personalId;
            this.userId = UserDAO.CreateID();
            this.name = name;
            this.birthday = birthday;
            this.email = email;
            this.phone = phone;
            this.gender = gender;
            this.address = address;
        }
    }
}
