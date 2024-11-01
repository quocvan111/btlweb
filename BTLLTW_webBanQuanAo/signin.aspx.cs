using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLLTW_webBanQuanAo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string username = Request.Form["username"];
                string password = Request.Form["password"];
                string re_password = Request.Form["re-password"];

                // Lấy danh sách người dùng từ Application (giả sử danh sách này lưu trữ ở đây)
                List<User> users = (List<User>)Application["Users"];

                // Kiểm tra tài khoản có tồn tại không
                bool userExists = users.Any(user => user.Taikhoan == username);
                if (userExists)
                {
                    notification.Attributes["class"] = "red";
                    notification.InnerHtml = "Tài khoản đã tồn tại!";
                    return;
                }

                // Kiểm tra mật khẩu nhập lại
                if (password != re_password)
                {
                    notification.Attributes["class"] = "red";
                    notification.InnerHtml = "Xác nhận lại mật khẩu không khớp!";
                    return;
                }

                // Nếu hợp lệ, thêm tài khoản mới vào danh sách
                int nextUserId = (int)Application["nextUserId"];
                User newUser = new User(nextUserId, username, password, "customer");
                users.Add(newUser);

                // Tăng giá trị nextUserId và lưu lại
                Application["nextUserId"] = nextUserId + 1;
                Application["Users"] = users;

                notification.Attributes["class"] = "green";
                notification.InnerHtml = "Đăng ký thành công!";

                //Response.Clear();
                //Response.ContentType = "application/json";
                //JavaScriptSerializer serializer = new JavaScriptSerializer();
                //string json = serializer.Serialize(users);
                //Response.Write(json);
                //Response.End();

            }
        }
    }
}