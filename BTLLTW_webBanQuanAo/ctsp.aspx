<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="ctsp.aspx.cs" Inherits="BTLLTW_webBanQuanAo.ctsp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style/base.css">
    <link rel="stylesheet" href="style/styleIndex.css">
    <link rel="stylesheet" href="style/styleDetail.css">
    <script src="scriptCTSP.js"></script>
</head>

<body>
    <form id="form1" runat="server">
    <div class="body">
        <div class="container">
            <div class="image col-6" id="hienAnh" runat="server"></div>
            <div class="info col-6">
                <div class="info-get-from-item" id="hienInfo" runat="server"></div>
                <br/>
                <div class="size">
                    <p>Size: <label for="" id="size_picked" runat="server"></label></p>
                    <button type="button" id="size_s" value="S" runat="server" onserverclick="Size_S_Click">S</button>
                    <button type="button" id="size_m" value="M" runat="server" onserverclick="Size_M_Click">M</button>
                    <button type="button" id="size_l" value="L" runat="server" onserverclick="Size_L_Click">L</button>
                    <button type="button" id="size_xl" value="XL" runat="server" onserverclick="Size_XL_Click">XL</button>
                </div>
                <br/>
                <p>Số lượng</p>
                <div class="row">
                <div class="quantity">
                    <button type="button" class="button button-remove" runat="server" onserverclick="btn_remove_quantityOnClick">-</button>
                    <input type="text" class="number" id="number_quantity" runat="server" value="1">
                    <button type="button" class="button button-add" runat="server" onserverclick="btn_add_quantityOnClick">+</button>
                </div>
                <button type="submit" class="button button-tocart" id="btn_cart" runat="server" onserverclick="btn_cart_OnClick">
                    <p>Thêm vào giỏ</p>
                </button>
                </div>
                <button type="submit" class="button-buy" runat="server" onserverclick="btn_buyNow_OnClick">Mua ngay</button>
                <div class="payment-method">
                    <div class="images">
                        <img src="resource/payment_method/zalopay.jpg" alt="" width="87px">
                        <img src="resource/payment_method/visa-card.jpg" alt="" width="45px">
                        <img src="resource/payment_method/master-card.jpg" alt="" width="58px">
                        <img src="resource/payment_method/vnpay-qr.jpg" alt="" width="87px">
                        <img src="resource/payment_method/momo.jpg" alt="" width="36px">
                    </div>
                    <p>Đảm bảo thanh toán an toàn và bảo mật</p>
                </div>
                <div class="info-policies">
                    <div class="inner-wrap">
                        <p><b>Miễn phí đổi trả: </b>Đơn hàng từ 498k</p>
                        <p><b>Giao hàng: </b>3 - 5 ngày trên cả nước</p>
                        <p><b>Miễn phí đổi trả: </b>Tại 267+ cửa hàng trong 15 ngày</p>
                        <p>Thông tin bảo mật và mã hoá</p>
                    </div>
                </div>
                <div class="info-describe">
                    <p><b>Mô tả sản phẩm</b></p>
                    <ul>
                        <li>
                            <div id="hienThongTin" runat="server"></div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
     </div>
</form>
</body>
</html>
</asp:Content>
