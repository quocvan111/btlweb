<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="BTLLTW_webBanQuanAo.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style/base.css">
    <link rel="stylesheet" href="style/styleIndex.css">
    <link rel="stylesheet" href="style/styleCart.css">
</head>
<body>
    <div class="body">
        <div class="container">
            <div class="left"></div>
            <div class="info-customer col-7">
                <div class="tilte"><h1>Thông tin đặt hàng</h1></div>
                <div class="row">
                    <div class="info-hoten col-9">
                        <label for="">Họ và tên</label>
                        <br>
                        <input type="text" name="txt_hoten" id="txt_hoten" placeholder="Nhập họ tên của bạn">
                    </div>
                    <div class="info-sdt col-3">
                        <label for="">Số điện thoại</label>
                        <input type="text" name="txt_sdt" id="txt_sdt" placeholder="Nhập SĐT">
                    </div>
                </div>
                <div class="row">
                    <div class="info-email col-12">
                        <label for="">Email</label>
                        <br>
                        <input type="text" name="txt_email" id="txt_email" placeholder="Nhập email của bạn">
                    </div>
                </div>
                <div class="row">
                    <div class="info-address col-12">
                        <label for="">Địa chỉ</label>
                        <br>
                        <input type="text" name="txt_dc" id="txt_dc" placeholder="Địa chỉ(ví dụ: 96 Định Công, Phương Liệt, Thanh Xuân, Hà Nội)">
                    </div>
                </div>
                <div class="row">
                    <div class="info-note col-12">
                        <label for="">Ghi chú</label>
                        <br>
                        <input type="text" name="txt_note" id="txt_note" placeholder="Ghi chú (Ví dụ: Giao hàng giờ hành chính ,...)">
                    </div>
                </div>

                <br>
                <hr>
                <br>
                
                <div class="payment-method">
                    <div class="title"><h1>Phương thức thanh toán</h1></div>
                    <button type="button" class="button-method" name="cod" id="cod">
                        <div class="row">
                            <img src="resource/payment_method/momo.jpg" alt="" width="87px">
                            <div class="inner-text">
                                <p>COD</p>
                                <p>Thanh toán khi nhận hàng</p>    
                            </div>
                        </div>
                    </button>
                    <button type="button" class="button-method" name="momo" id="momo">
                        <div class="row">
                            <img src="resource/payment_method/momo.jpg" alt="" width="87px">
                            <div class="inner-text" style="margin-top: 13px;">
                                <p>Thanh toán MoMo</p>
                            </div>
                        </div>
                    </button>
                    <button type="button" class="button-method" name="zalopay" id="zalopay">
                        <div class="row">
                            <img src="resource/payment_method/zalopay.jpg" alt="" width="100px">
                            <div class="inner-text">
                                <p>Ví điện tử ZaloPay</p>
                                <p>Thẻ ATM / Thẻ tín dụng / Thẻ ghi nợ</p>        
                            </div>
                        </div>
                    </button>
                    <button type="button" class="button-method" name="vnpay" id="vnpay">
                        <div class="row">
                            <img src="resource/payment_method/vnpay-qr.jpg" alt="" width="100px">
                            <div class="inner-text">
                                <p>Ví điện tử VNPAY</p>
                                <p>QR Code thanh toán qua ngân hàng</p>
                            </div>
                        </div>
                    </button>
                </div>
            </div>
            <div class="cart col-5">
                <div class="title">
                    <h1>Giỏ hàng</h1>
                </div>
                <div class="info-cart has-item" id="hienItem" runat="server">

                </div>
            </div>
            </div>
        </div>
    </body>
    <

</asp:Content>
