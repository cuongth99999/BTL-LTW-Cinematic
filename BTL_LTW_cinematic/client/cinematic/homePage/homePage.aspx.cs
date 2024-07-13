using BTL_LTW_cinematic.Class;
using BTL_LTW_cinematic.client.cinematic.buyticket;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_LTW_cinematic.client.cinematic.homePage
{
    public partial class homePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList app = (ArrayList)Application["users"];
            User user = (User)Session["user"];
            foreach (User u in app)
            {
                if (user.userName == u.userName && user.passWord == u.passWord)
                {
                    Button2.Text = "xin chào " + user.userName;
                    // Button3.Text = "Đăng xuất";
                    dropdown.Style["display"] = "block";
                    Button7.Visible = false;
                }
            }
            if (user.userName == "admin")
            {
                Button1.Text = "sửa phim";
                datVeNgay_themPhim.Visible = true;
                datVeNgay_themPhim.Text = "thêm phim";
            }
            int idphim = (int)Session["idphim"];
            idphim = int.Parse(idmovie.Value);
            Session["idphim"] = idphim;
            if (idphim != 0)
            {
                Response.Redirect("../buyticket/buyticket.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e) // button : logout
        {
           
            
                Response.Redirect("../register/register.aspx");
            
        }

        protected void Button5_Click(object sender, EventArgs e) // button : changePassword
        {
            if (Button5.Text == "Đổi mật khẩu")
            {
                Response.Redirect("../changePassword/changePassword.aspx");

            }
        }
        protected void Button2_Click(object sender, EventArgs e) // button : dn
        {

            if (Button2.Text == "Đăng nhập")
            {
                Response.Redirect("../login/login.aspx");
            }
            else
            {
                Response.Redirect("../receipt/receipt.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)//phim sap chieu
        {
            Response.Redirect("../upComingFilm/upComingFilm.aspx");
        }

        protected void datVeNgay_themPhim_Click(object sender, EventArgs e)
        {
            Response.Redirect("../addFilm/addFilm.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["search"] = search_txt.Value.ToString();
            Response.Redirect("../search/search.aspx");
        }
    }
}