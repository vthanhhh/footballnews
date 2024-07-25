<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="trangchu.aspx.cs" Inherits="footballnews.Content.trangchu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="trangchu.css">
    <meta name="viewport" content="width=device-width, initial-scale=1">
</head>
<body>
    <form id="form1" runat="server" action="~/Content/trangchu.aspx.cs">
    <header class="header">
        <p>3Ball.com</p>
        <div class="account">
            <span id="NameAccount" runat="server"></span> 
            <ul class="list_account">
                <li class="title_account">
                    <span id="account" runat="server">Tài khoản của tôi</span>
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
    </form>
    <main>
        <div class="content padding-inline-l">
                <div class="advertisement">
                           <img src="https://m.media-amazon.com/images/I/81noQg1m14L._SY466_.jpg" alt="Alternate Text" />
                        </div>
               <div class="news-wrapper">
                   <h1>Tin tức</h1>
                     <div class="row-news" id="news" runat="server"></div>
                     <h1>Giải đấu</h1>
                     <div class="row-news" id="league" runat="server"></div>
                     <h1>Lịch thi đấu</h1>
                     <div class="row-news" id="schedule" runat="server"></div>
                     <h1>Highlight</h1>
                     <div class="row-news" id="highlight" runat="server"></div>
                </div>
                <div class="advertisement">
                   <img src="https://m.media-amazon.com/images/I/81noQg1m14L._SY466_.jpg" alt="Alternate Text" />
                </div>
            </div>
    </main>
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
</body>
</html>
