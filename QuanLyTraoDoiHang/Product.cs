using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    public class Product
    {
        public int productId = 0;
        public int sellerId;
        public string category;
        public string name;
        public int price;
        public Image image;

        public int originalPrice;
        public string condition;
        public string warrantyPolicy;
        public DateOnly dateBought;
        public string brand;
        public string origin;
        public string description;

        public Product() { }

        public Product(int sellerId, string category, string name, int price, Image image, int originalPrice, string condition, string warrantyPolicy, DateOnly dateBought, string brand, string origin, string description)
        {
            this.productId = ProductDAO.CreateID();
            this.sellerId = sellerId;
            this.category = category;
            this.name = name;
            this.price = price;
            this.image = image;
            this.originalPrice = originalPrice;
            this.condition = condition;
            this.warrantyPolicy = warrantyPolicy;
            this.dateBought = dateBought;
            this.brand = brand;
            this.origin = origin;
            this.description = description;

        }
    }

}
