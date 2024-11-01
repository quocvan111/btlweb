<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BTLLTW_webBanQuanAo.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style/base.css">
    <link rel="stylesheet" href="style/styleLogin.css">
</head>

<body>
    <div class="body">
        <div class="inner-wrap">
            <form action="" method="post" class="form">
                <div class="row">
                    <h1>Đăng nhập</h1>
                    <a href="signin.aspx">Đăng ký</a>
                </div>
                <hr/>
                <div class="content">
                    <p>Tên đăng nhập</p>
                        <input type="text" name="username" id="username" placeholder="Nhập tên đăng nhập">
                    <p>Mật khẩu</p>
                    <input type="password" name="passowrd" id="password" placeholder="Nhập tên mật khẩu">
                    <label for="" class="hidden" id="notification" runat="server">test</label>
                </div>
                <input type="submit" value="Đăng nhập" class="button" onclick="clickLogin(event);">
            </form>                
        </div>
    </div>
    <script src="Scripts/scriptLogin.js"></script>
</body>
</html>



</asp:Content>
