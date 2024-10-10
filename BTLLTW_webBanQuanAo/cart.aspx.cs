using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLLTW_webBanQuanAo
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = renderItem();
            List<Item> items = (List<Item>)Application["itemList"];
            hienItem.InnerHtml = s;
        }

        private string renderItem()
        {
            string html = "";
            List<Item> list = (List<Item>)Application["itemList"];
            string id = Request.QueryString["id"];
            if(id == null)
            {
                html += "Chưa có sản phẩm nào trong giỏ hàng !";
            }
            else
            {
                foreach (Item item in list)
                {
                    if (item.Id == Int32.Parse(id))
                    {
                        html += generateString(item);
                    }
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

        private string generateString(Item item)
        {
            int quantity = 1;
            string html = "";

            html += "<div class='row'>" +
                        "<div class='item-img'>" +
                            "<img src='" + item.Image + "' alt='' width='120px'>" +
                        "</div>" +
                        "<div class='item-info'>" +
                            "<h3>" + item.Name + "</h3>" +
                            "<p>" + renderCategory(item) + "</p>" +
                            "<div class='row-2'>" +
                                "<div class='quantity'>" +
                                    "<button class='button button-remove'>-</button>" +
                                    "<div class='number' id='number-quantity'>" + quantity + "</div>" +
                                    "<button class='button button-add'>+</button>" +
                                "</div>" +
                                "<div class='price'>" + item.Final_price.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " đ</div>" +
                            "</div>" +
                            "<div class='delete'>" +
                                "<button type='button' class='xoa'>Xóa</button>" +
                            "</div>" +
                        "</div>" +
                    "</div>" +
                    "<br>" +
                    "<hr>" +
                    "<br>";

            html += "<div class='price-cart'>" +
                        "<div class='row'>" +
                            "<p>Tạm tính</p>" +
                            "<div class='price'><p>" + (item.Final_price * quantity).ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " đ</p></div>" +
                        "</div>" +
                        "<div class='row'>" +
                            "<p>Giảm giá</p>" +
                            "<div class='price'><p>" + 0 + " đ</p></div>" +
                        "</div>" +
                        "<div class='row'>" +
                            "<p>Phí giao hàng</p>" +
                            "<div class='price'><p>Miễn phí</p></div>" +
                        "</div>" +
                        "<br>" +
                        "<hr>" +
                        "<br>" +
                        "<div class='row'>" +
                            "<p>Tổng</p>" +
                            "<div class='total-price'><b><p>" + (item.Final_price * quantity).ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " đ</p></b></div>" +
                        "</div>" +
                    "</div>" +
                    "<br>" +
                    "<button type='button' class='purchase'>Thanh toán</button>";

            return html;
        }



    }
}