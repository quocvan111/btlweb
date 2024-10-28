using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLLTW_webBanQuanAo
{
    public class Item
    {
        // FOR CATEGORY:
        // 1 --> 4: NAM 
        // 1: Do mac hang ngay (m_casual)
        // 2: Do cong so (m_works)
        // 3: Do the thao (m_sports)
        // 4: Do lot (m_underwear)
        // Tuong tu: 5 -- > 9: NU (f_casual , f_ ,...)
        // 10: Tre em (kids)

        public int id;
        public string name, image;
        public int category;
        public int price, final_price;
        public string description;
        


        public Item(int id, string name, string image, int category, int price, int final_price, string description)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.category = category;
            this.price = price;    
            this.final_price = final_price;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Image { get => image; set => image = value; }
        public int Category { get => category; set => category = value; }
        public int Price { get => price; set => price = value; }
        public int Final_price { get => final_price; set => final_price = value; }
        public string Description { get => description; set => description = value; }
    }
}