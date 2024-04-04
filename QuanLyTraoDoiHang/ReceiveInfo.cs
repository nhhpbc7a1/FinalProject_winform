using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    public class ReceiveInfo
    {
        public int receiveId;
        public int userId;
        public string name;
        public string phone;
        public string address;
        public ReceiveInfo() { }
        public ReceiveInfo(int userId, string name, string phone, string address)
        {
            receiveId = ReceiveInfoDAO.CreateID();
            this.userId = userId;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }
    }
}
