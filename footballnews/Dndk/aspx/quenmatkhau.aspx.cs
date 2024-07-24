using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace footballnews.Dndk.aspx
{
    public partial class quenmatkhau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tk = Request.Form["username"];
            string mk = Request.Form["password"];
            string mk1 = Request.Form["repassword"];
            List<taikhoan> ds = (List<taikhoan>)Application["dstaikhoan"];
            taikhoan existingAccount = ds.FirstOrDefault(t => t.User == tk);
            if (existingAccount == null)
            {
                Response.Write("<script>alert('Tài khoản không tồn tại.')</script>");
                return;
            }
            else
            {
                existingAccount.Password = mk;
                Application["dstaikhoan"] = ds;
                Response.Write("<script>alert('Đổi mật khẩu thành công.')</script>");
                Response.Redirect("/html-css/dangnhap.html");
            }
        }
    }
}