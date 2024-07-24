using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace footballnews.Dndk.aspx
{
    public partial class dangky : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                taikhoan dk = new taikhoan();
                dk.User = Request.Form["username"];
                dk.Password = Request.Form["password"];
                List<taikhoan> ds = (List<taikhoan>)Application["dstaikhoan"];
                //ds.Add(dk);
                //Application["dstaikhoan"] = ds;
                taikhoan existingAccount = ds.FirstOrDefault(t => t.User == dk.User);
                if (existingAccount != null)
                {
                    Response.Write("<script>alert('Tài khoản đã tồn tại')</script>");
                    //string script = "<script>document.getElementById('notification').innerText = 'Tài khoản đã tồn tại';</script>";
                    //Response.Write(script);
                }
                else
                {
                    // Thêm tài khoản mới vào danh sách
                    ds.Add(dk);
                    Application["dstaikhoan"] = ds;
                    Response.Write("<script>alert('Đăng ký thành công!')</script>");
                    /*string script = "<script>document.getElementById('notification').innerText = 'Đăng ký thành công!';</script>";
                    Response.Write(script);*/
                    Response.Redirect("dangnhap.aspx");
                }
            }
            

        }
    }
}