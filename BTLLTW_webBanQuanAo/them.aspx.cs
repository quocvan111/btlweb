using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLLTW_webBanQuanAo
{
    public partial class them : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Item> items = (List<Item>)Application["itemList"];

            if (IsPostBack)
            {
                int id = Convert.ToInt32(Request.Form["id"]);
                string name = Request.Form["name"];
                HttpPostedFile image = Request.Files["image"];
                int category = Convert.ToInt32(Request.Form["category"]);
                int price = Convert.ToInt32(Request.Form["price"]);
                int final_price = Convert.ToInt32(Request.Form["final_price"]);
                string describe = Request.Form["describe"];

                for (int i = items.Count - 1; i >= 0; i--)
                {
                    if (items[i].Id == id)
                    {
                        items.RemoveAt(i);

                    }
                }
                string Nameimage = Path.GetFileName(image.FileName);
                string sourceImage = "";
                if (category == 1)
                {
                    string path = Server.MapPath("~/resource/male_casual/" + Nameimage);
                    sourceImage = "resource/male_casual/" + Nameimage;
                    image.SaveAs(path);
                }
                if (category == 2)
                {
                    string path = Server.MapPath("~/resource/male_work/" + Nameimage);
                    sourceImage = "resource/male_work/" + Nameimage;
                    image.SaveAs(path);
                }
                if (category == 3)
                {
                    string path = Server.MapPath("~/resource/male_sport/" + Nameimage);
                    sourceImage = "resource/male_sport/" + Nameimage;
                    image.SaveAs(path);
                }
                if (category == 4)
                {
                    string path = Server.MapPath("~/resource/female_casual/" + Nameimage);
                    sourceImage = "resource/female_casual/" + Nameimage;
                    image.SaveAs(path);
                }
                if (category == 5)
                {
                    string path = Server.MapPath("~/resource/female_work/" + Nameimage);
                    sourceImage = "resource/female_work/" + Nameimage;
                    image.SaveAs(path);
                }
                if (category == 6)
                {
                    string path = Server.MapPath("~/resource/female_sport/" + Nameimage);
                    sourceImage = "resource/female_sport/" + Nameimage;
                    image.SaveAs(path);
                }
                if (category == 7)
                {
                    string path = Server.MapPath("~/resource/kids/" + Nameimage);
                    sourceImage = "resource/kids/" + Nameimage;
                    image.SaveAs(path);
                }

                items.Add(new Item(id, name, sourceImage, category, price, final_price, describe));
                Application["itemList"] = items;
            }

            string chuoi = "";
            int stt = 1;
            chuoi += "<table><tr><td>STT</td><td>ID</td><td>Tên sản phẩm</td><td>Đường dẫn ảnh</td><td>Loại</td><td>Giá</td><td>Giá cuối</td><td>Mô tả</td></tr>";
            foreach (Item item in items)
            {
                chuoi += "<tr><td>" + stt + "</td> <td>" + item.Id + "</td> <td>" + item.Name + "</td> <td>" + item.Image + "</td><td>" + item.Category + "</td><td>" + item.Price + "</td><td>" + item.Final_price + "</td><td>" + item.Description + "</ td ></ tr > ";
                chuoi += "<td><a href='them.aspx?sua=" + item.Id + "&name=" + item.Name + "&image=" + item.Image + "&category=" + item.Category + "&price=" + item.Price + "&final_price=" + item.Final_price + "&describe=" + item.Description + "'>Sửa</a>";
                chuoi += "<td><a href='them.aspx?delete=" + item.Id + "'>Xóa</a></tr>";
                stt++;
            }

            chuoi += "</table>";
            hienthidanhsach.InnerHtml = chuoi;
            int deletesp = Convert.ToInt32(Request.QueryString["delete"]);
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (items[i].Id == deletesp)
                {
                    items.RemoveAt(i);
                    Response.Redirect("them.aspx");
                }
            }

            id.Value = Request.QueryString["sua"];
            name.Value = Request.QueryString["name"];
            category.Value = Request.QueryString["category"];
            price.Value = Request.QueryString["price"];
            final_price.Value = Request.QueryString["final_price"];
            describe.Value = Request.QueryString["describe"];
        }
    }
}