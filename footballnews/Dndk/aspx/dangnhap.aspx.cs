using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace footballnews.Dndk.aspx
{
    public partial class dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tk = Request.Form["username"];
            string mk = Request.Form["password"];
            List<taikhoan> ds = (List<taikhoan>)Application["dstaikhoan"];
            taikhoan existingAccount = ds.FirstOrDefault(t => t.User == tk && t.Password == mk);
            if (existingAccount != null)
            {
                Session["LoggedInUserName"] = existingAccount.User;
                //Session["UserRole"] = existingAccount.id.Equals("admin", StringComparison.OrdinalIgnoreCase) ? "Admin" : "User";
                Response.Write("<script>alert('Đăng nhập thành công!')</script>");
                // Chuyển hướng tới trang chính
                Response.Redirect("/Content/trangchu.aspx");
            }
            else
            {
                Response.Write("<script>alert('Tên tài khoản hoặc mật khẩu không chính xác.')</script>");
            }

        }
    }
}