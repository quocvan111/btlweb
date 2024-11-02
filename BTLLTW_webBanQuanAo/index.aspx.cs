using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLLTW_webBanQuanAo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = renderItemList();
            List<Item> listItem = (List<Item>)Application["itemList"];
            hienoday.InnerHtml = s;
        }

        private string renderItemList()
        {
            string sHTML = "<div class='row'>";
            List<Item> list = (List<Item>)Application["itemList"];
            for (var i = 0; i < 4; i++)
            {
                sHTML += "<div class='item'>" +
                            "<a href='ctsp.aspx?id=" + list[i].Id + "'>" +
                                "<img src='" + list[i].Image + "' alt=''>" +
                            "</a>" +
                            "<div class='item-info'>" +
                                "<p>" + list[i].Name + "<br/></p>" +
                                "<div class='price'>";

                if (list[i].Price == 0)
                {
                    sHTML += "<p class='price-after' style = 'color: black'>" + list[i].Final_price.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " đ</p>";
                }
                else
                {
                    sHTML += "<p class='price-after'>" + list[i].Final_price.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " đ</p>" +
                             "<sub class='price-before'>" + list[i].Price.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " đ</sub>";
                }

                sHTML += "</div>" + 
                        "</div>" +  
                     "</div>";       
            }
            sHTML += "</div>";
            return sHTML;
        }
    }
}