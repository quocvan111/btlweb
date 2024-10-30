<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="them.aspx.cs" Inherits="BTLLTW_webBanQuanAo.them" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
             id: <input type="text" id="id" name="id" runat="server"/><br /><br />
             name: <input type="text" id="name" name="name" runat="server"/> <br /> <br />
             image: <input type="file" id="image" name="image" runat="server"/><br /><br />
             category: <input type="text" id="category" name="category" runat="server" /> <br /><br />
             price: <input type="text" id="price" name="price" runat="server"/> <br /><br />
             final_price: <input type="text" id="final_price" name="final_price" runat="server"/> <br /><br />
             describe: <textarea type="text" id="describe" name="describe" runat="server"></textarea><br /><br />
            <input type="submit" name="luu" value="Thêm " runat="server"/><br /><br />
            
        </div>
    </form>
    <a href="index.aspx">Về trang chủ</a><br /><br />
     <div id="hienthidanhsach" runat="server"></div>
</body>
</html>
