<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="BTLLTW_webBanQuanAo.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style/base.css">
    <link rel="stylesheet" href="style/styleIndex.css">
    <title>Document</title>
</head>
<body>
    <div class="body">
        <div class="inner-wrap">
            <form action="" method="post" class="form">
                <div class="row">
                    <h1>Đăng ký</h1>
                    <a href="login.aspx">Quay về đăng nhập</a>
                </div>
                <hr/>
                <div class="content">
                    <p>Tên đăng nhập</p>
                        <input type="text" name="username" id="username" placeholder="Nhập tên đăng nhập">
                    <p>Mật khẩu</p>
                    <input type="password" name="passowrd" id="password" placeholder="Nhập tên mật khẩu">
                    <p>Nhập lại mật khẩu</p>
                    <input type="password" name="passowrd" id="re-password" placeholder="Nhập tên lại mật khẩu">
                    <label for="" class="notification hidden">test</label>
                </div>
                <input type="submit" value="Đăng ký" class="button">
            </form>                
        </div>
    </div>
        <link rel="stylesheet" href="style/styleSignin.css">
</body>
</html>
</asp:Content>
