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
        protected void Page_Load(object sender, EventArgs e)
        {
            // dsTintuc = (List<tin>)Application["dsTintuc"];
            // dsGiaiDau = (List<tin>)Application["dsGiaiDau"];
            // dsLichThiDau = (List<tin>)Application["dsLichThiDau"];
            // dsHighlight = (List<tin>)Application["dsHighlight"];
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
                BindNews("dsTintuc",news);
                BindNews("dsGiaiDau",league);
                BindNews("dsLichThiDau",schedule);
                BindNews("dsHighlight",highlight);



            }
        }
        
        private void BindNews(String type,HtmlGenericControl container)
        {
            List<tin> dsTintuc = (List<tin>)Application[type];
            string innerHtml = "";
            foreach(tin tintuc in dsTintuc)
            {
                innerHtml += $@"
                        <div class=""news-card""><div class=""image-news""><img src=""{tintuc.img}"" alt=""{tintuc.title}"" /></div>
                        <a href=""/Content/chittiettin.aspx?id={tintuc.id}&type={type}""class=""tittle-news""><h4>{tintuc.title}</h4></a></div>";
            }
            container.InnerHtml = innerHtml;
        }
    }
}