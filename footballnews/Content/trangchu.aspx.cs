using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace footballnews.Content
{
    public partial class trangchu : System.Web.UI.Page
    {
        private List<tin> dsTintuc;
        private List<tin> dsGiaiDau;
        private List<tin> dsLichThiDau;
        private List<tin> dsHighlight;
        protected void Page_Load(object sender, EventArgs e)
        {
            dsTintuc = (List<tin>)Application["dsTintuc"];
            dsGiaiDau = (List<tin>)Application["dsGiaiDau"];
            dsLichThiDau = (List<tin>)Application["dsLichThiDau"];
            dsHighlight = (List<tin>)Application["dsHighlight"];
            // Kiểm tra xem có Session lưu tên đăng nhập không
            if (!IsPostBack)
            {
                if (Session["LoggedInUserName"] != null)
                {
                    string loggedInUserName = Session["LoggedInUserName"].ToString();

                    if (loggedInUserName == "admin")
                    {
                        // If the user is an admin, set the link to the admin page
                        //NameAccount.Inner = "<a '\\Content\\Trangadmin.aspx'></a>";
                        NameAccount.InnerText = loggedInUserName;
                        account.InnerHtml = "<a href='/Content/Trangadmin.aspx'>Trang quản lí</a>";
                    }
                    else
                    {
                        // If the user is not an admin, just display the username
                        NameAccount.InnerText = loggedInUserName;
                    }
                }
                else
                {
                    NameAccount.InnerHtml = "<a href='/Dndk/html-css/dangnhap.html'>Đăng nhập</a>";
                }
                BindNews();
                BindGiaiDau();
                BindLichThiDau();
                BindHighlight();


            }
        }
        
        private void BindNews()
        {
            string htmltin = "";
            foreach(tin tintuc in dsTintuc)
            {
                htmltin += $@"
                        <div class=""image-news""><img src=""{tintuc.img}"" alt=""{tintuc.title}"" /></div>
                        <a href=""/Content/chittiettin.aspx?id={tintuc.id}&type=dsTintuc""class=""tittle-news"">{tintuc.title}</a>";
            }
            news.InnerHtml = htmltin;
        }
        private void BindGiaiDau()
        {
            string htmltin = "";
            foreach (tin tintuc in dsGiaiDau)
            {
                htmltin += $@"
                        <div class=""image-news""><img src=""{tintuc.img}"" alt=""{tintuc.title}"" /></div>
                        <a href=""/Content/chittiettin.aspx?id={tintuc.id}&type=dsGiaiDau""class=""tittle-news"">{tintuc.title}</a>";
            }
            league.InnerHtml = htmltin;
        }
        private void BindLichThiDau()
        {
            string htmltin = "";
            foreach (tin tintuc in dsLichThiDau)
            {
                htmltin += $@"
                        <div class=""image-news""><img src=""{tintuc.img}"" alt=""{tintuc.title}"" /></div>
                        <a href=""/Content/chittiettin.aspx?id={tintuc.id}&type=dsLichThiDau""class=""tittle-news"">{tintuc.title}</a>";
            }
            schedule.InnerHtml = htmltin;
        }
        private void BindHighlight()
        {
            string htmltin = "";
            foreach (tin tintuc in dsHighlight)
            {
                htmltin += $@"
                        <div class=""image-news""><img src=""{tintuc.img}"" alt=""{tintuc.title}"" /></div>
                        <a href=""/Content/chittiettin.aspx?id={tintuc.id}&type=dsHighlight""class=""tittle-news"">{tintuc.title}</a>";
            }
            highlight.InnerHtml = htmltin;
        }
    }
}