using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebGrease;

namespace BTLLTW_webBanQuanAo
{
    public partial class ctsp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = renderItemThumbnail();
            string s1 = renderItemInfo();
            List<Item> items = (List<Item>)Application["itemList"];
            hienAnh.InnerHtml = s;
            hienInfo.InnerHtml = s1;
            hienThongTin.InnerHtml = renderItemDescription();
        }

        private string renderItemThumbnail()
        {
            string html = "";
            List<Item> list = (List<Item>)Application["itemList"];
            string id = Request.QueryString["id"];
            foreach (Item item in list)
            {
                if(item.Id == Int32.Parse(id))
                {
                    html += generateStringThumbnail(item);
                }
            }
            return html;
        }

        private string renderItemInfo()
        {
            string html = "";
            List<Item> list = (List<Item>)Application["itemList"];
            string id = Request.QueryString["id"];
            
            foreach (Item item in list)
            {
                if (item.Id == Int32.Parse(id))
                {
                    html += generateStringInfo(item);
                }
            }
            return html;
        }

        private string renderItemDescription()
        {
            string html = "";
            List<Item> list = (List<Item>)Application["itemList"];
            string id = Request.QueryString["id"];

            foreach (Item item in list)
            {
                if (item.Id == Int32.Parse(id))
                {
                    html += generateStringDescription(item);
                }
            }
            return html;
        }

        public string renderCategory(Item item)
        {
            if (item.Category == 1 || item.Category == 4)
                return "Đồ mặc hằng ngày";
            if (item.Category == 2 || item.Category == 5)
                return "Đồ công sở";
            if (item.Category == 3 || item.Category == 6)
                return "Đồ thể thao";
            else return "Đồ trẻ em";
        }

        private string generateStringThumbnail(Item item)
        {
            string html = "";
            html += "<img src='" + item.Image + "' alt=''>";
            return html;
        }

        private string generateStringInfo(Item item)
        {
            string html = "";
            html += "<div class='title'><h3>" + item.Name + "</h3></div>" +
                        "<div class='category'>" + renderCategory(item) + "</div>" +
                        "<div class='price'><h2>" + item.Final_price.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " đ</h2></div>";
            return html;
        }

        private string generateStringDescription(Item item) 
        {
            string html = "";
            html += item.Description;
            return html;
        }

        public void clickbtnCart()
        {

        }
    }
}