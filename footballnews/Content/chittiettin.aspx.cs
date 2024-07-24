using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace footballnews.Content
{
    public partial class chittiettin : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LoggedInUserName"] != null)
                {
                    string loggedInUserName = Session["LoggedInUserName"].ToString();
                    NameAccount.InnerText = loggedInUserName;

                    // Hiển thị tên đăng nhập
                }
                /*else if (Session["LoggedInAdminName"] != null)
                {
                    string loggedInAdminName = Session["LoggedInAdminName"].ToString();
                    NameAccount.InnerText = loggedInAdminName;
                    NameAccount.InnerHtml = "<a href='/Content/chittiettin.aspx'>Trang quản lí</a>";
                }*/
                else
                {
                    // Nếu chưa đăng nhập thì chuyển hướng về trang đăng nhập
                    NameAccount.InnerHtml = "<a href='/Dndk/html-css/dangnhap.html'>Đăng nhập</a>";
                    //"<a href='Login.aspx'>Đăng nhập</a>"
                }
                string id = Request.QueryString["id"];
                string type = Request.QueryString["type"];
                List<tin> dsTintuc = (List<tin>)Application[type];
                tin tin = dsTintuc.FirstOrDefault(t => t.Id == id);
                //render
                string td = tin.Title;
                tieude.InnerHtml = td;
                string Img = $"<image src='{tin.img}'/>";
                anh.InnerHtml = Img;
                string Content = tin.Content;
                noidung.InnerHtml = Content;
            }
        }
    }
}