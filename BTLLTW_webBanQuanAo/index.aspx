<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BTLLTW_webBanQuanAo.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style/base.css">
    <link rel="stylesheet" href="style/styleIndex.css">
</head>

<body>
    <div class="body">
        <div class="main-banner">
            <a href="#"><img src="resource/section_banner_1.jpg" alt="" width="100%"></a>
        </div>
        <div class="section-one">
            <div class="head-container">
                <div class="title">
                    <h2>Sản phẩm ưa chuộng</h2>
                </div>
                <br />
            </div>
            <div class="content-container">
                    <div id="hienoday" runat="server"></div>
            </div>
        </div>
        <div class="section-two">
            <div class="head-container">
                <div class="row">
                    <h2>Danh mục sản phẩm</h2>
                </div>
            </div>
            <div class="content-container">
                    <div class="row">
                        <div class="item">
                            <img src="resource/ThoiTrangNam.jpg" alt="">
                            <div class="inner-title">
                                <h2>Thời trang nam</h2>
                                <a href="dssp.aspx?category=male" class="button button-one">Xem ngay</a>
                            </div>
                        </div>
                        <div class="item">
                            <img src="resource/ThoiTrangNu.jpg" alt="">
                            <div class="inner-title">
                                <h2>Thời trang nữ</h2>
                                <a href="dssp.aspx?category=female" class="button button-one">Xem ngay</a>
                            </div>
                        </div>
                        <div class="item">
                            <img src="resource/ThoiTrangTreEm.jpg" alt="">
                            <div class="inner-title">
                                <h2>Thời trang trẻ em</h2>
                                <a href="dssp.aspx?category=kid" class="button button-one">Xem ngay</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </body>
</html>
</asp:Content>
