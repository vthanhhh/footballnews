<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chittiettin.aspx.cs" Inherits="footballnews.Content.chittiettin" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="trangchu.css">
</head>
<body>
    <form id="form1" runat="server" method="get">
        <header class="header">
            <p>3Ball.com</p>
            <div class="account">
                <span id="NameAccount" runat="server"></span>
                <ul class="list_account">
                    <li class="title_account">
                        <span>Tài khoản của tôi</span>
                    </li>
                    <li class="title_account">
                        <a style="text-decoration: none" href="../Dndk/html-css/dangnhap.html">Đăng xuất
                        </a>
                    </li>
                </ul>
            </div>
            <input type="text" placeholder="Tìm kiếm" />
        </header>
        <div id="menu">
            <ul class="ul-containers">
                <li class="list"><a class="link" href=""><b>Lịch thi đấu</b></a></li>
                <li class="list"><a class="link" href=""><b>Video & Phát trực tiếp</b></a></li>
                <li class="list"><a class="link" href=""><b>Tin tức</b></a></li>
                <li class="list menu-dropdown">
                    <a class="link" href="#"><b>Giải đấu</b></a>
                    <div class="menu-items">
                        <ul class="list-options">
                            <li><a href="" class="options">Việt Nam</a></li>
                            <li><a href="" class="options">WorldCup</a></li>
                            <li><a href="" class="options">Euro</a></li>
                            <li><a href="" class="options">Premier League</a></li>
                            <li><a href="" class="options">La Liga</a></li>
                            <li><a href="" class="options">Champions League</a></li>
                        </ul>
                    </div>
                </li>
            </ul>
        </div>
        <div class ="content">
            <h1 class ="tieude" id="tieude" runat="server"></h1>
            <div class="anh" id="anh" runat="server"></div>
            <div class="noidung" id="noidung" runat="server"></div>
        </div>
        <footer class="footer">
            <div class="gt">
                <a href="home.aspx">3Ball.com</a>
                <p>Địa chỉ: 96 Định Công, Hoàng Mai, Hà Nội</p>
                <p>Điện thoại: 0123456789</p>
            </div>
            <div class="link1">
                <p>facebook</p>
                <p>instagram</p>
                <p>twetter</p>
            </div>
            <div class="link2">
                <p>image</p>
                <p>image</p>
                <p>image</p>
            </div>
        </footer>
    </form>
</body>
</html>
