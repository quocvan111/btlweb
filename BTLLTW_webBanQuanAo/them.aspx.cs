using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;

namespace BTLLTW_webBanQuanAo
{
    public partial class them : System.Web.UI.Page
    {
        private int inputID, inputCategory, inputPrice, inputFinal_Price;
        private string inputName, inputImage, inputDescription;
        private string fileName;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Item> items = Application["itemList"] as List<Item> ?? new List<Item>();

            if (!string.IsNullOrEmpty(Request.Form["id"]))
            {
                inputID = int.TryParse(Request.Form["id"], out int idValue) ? idValue : items.Count + 1;
                inputName = Request.Form["name"];
                inputCategory = Convert.ToInt32(Request.Form["category"]);
                inputPrice = Convert.ToInt32(Request.Form["price"]);
                inputFinal_Price = Convert.ToInt32(Request.Form["final_price"]);
                inputDescription = Request.Form["describe"];


                if (Request.QueryString["delete"] != null)
                {
                    int deletesp;
                    if (int.TryParse(Request.QueryString["delete"], out deletesp))
                    {
                        items.RemoveAll(item => item.Id == deletesp);


                        Application["itemList"] = items;
                        Response.Redirect("them.aspx"); 
                        return; 
                    }
                }

                // Kiểm tra nếu đang sửa
                if (Request.QueryString["sua"] != null)
                {
                    UpdateItem(items, inputID);
                    Application["itemList"] = items;
                    Response.Redirect("them.aspx");
                }
                else
                {
                    if (Request.Files["image"] != null && Request.Files["image"].ContentLength > 0)
                    {
                        saveFile(Request.Files["image"], Server.MapPath("~/resource/"));
                        inputImage = "resource/" + fileName;

                        items.Add(new Item(inputID, inputName, inputImage, inputCategory, inputPrice, inputFinal_Price, inputDescription));
                        Application["itemList"] = items;
                        Response.Redirect("them.aspx");
                    }
                }
            }

            // Hiển thị danh sách sản phẩm
            DisplayItems(items);

            if (Request.QueryString["sua"] != null)
            {
                id.Value = Request.QueryString["sua"];
                name.Value = Request.QueryString["name"];
                category.Value = Request.QueryString["category"];
                price.Value = Request.QueryString["price"];
                final_price.Value = Request.QueryString["final_price"];
                describe.Value = Request.QueryString["describe"];
            }
        }

        public void saveFile(HttpPostedFile file, string path)
        {
            fileName = Path.GetFileName(file.FileName);
            string filePath = Path.Combine(path, fileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            file.SaveAs(filePath);
        }

        private void UpdateItem(List<Item> items, int id)
        {
            foreach (Item item in items)
            {
                if (item.Id == id)
                {
                    item.Name = inputName;
                    item.Category = inputCategory;
                    item.Price = inputPrice;
                    item.Final_price = inputFinal_Price;
                    item.Description = inputDescription;

                    if (Request.Files["image"] != null && Request.Files["image"].ContentLength > 0)
                    {
                        saveFile(Request.Files["image"], Server.MapPath("~/resource/"));
                        item.Image = "resource/" + fileName;
                    }
                    break;
                }
            }
        }

        private void DisplayItems(List<Item> items)
        {
            string tableHtml = "<table><tr><td>STT</td><td>ID</td><td>Tên sản phẩm</td><td>Đường dẫn ảnh</td><td>Loại</td><td>Giá</td><td>Giá cuối</td><td>Mô tả</td></tr>";
            int stt = 1;
            foreach (Item item in items)
            {
                tableHtml += $"<tr><td>{stt}</td><td>{item.Id}</td><td>{item.Name}</td><td>{item.Image}</td><td>{item.Category}</td><td>{item.Price}</td><td>{item.Final_price}</td><td>{item.Description}</td>";
                tableHtml += $"<td><a href='them.aspx?sua={item.Id}&name={item.Name}&image={item.Image}&category={item.Category}&price={item.Price}&final_price={item.Final_price}&describe={item.Description}'>Sửa</a></td>";
                tableHtml += $"<td><a href='them.aspx?delete={item.Id}'>Xóa</a></td></tr>";
                stt++;
            }
            tableHtml += "</table>";
            hienthidanhsach.InnerHtml = tableHtml;
        }
    }
}
